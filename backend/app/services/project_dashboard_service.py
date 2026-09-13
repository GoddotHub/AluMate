from sqlalchemy.orm import Session

from app.models.customer import Customer
from app.models.project import Project
from app.models.project_expense import ProjectExpense
from app.models.project_item import ProjectItem

from app.services.project_cost_service import calculate_project_cost

from app.services.project_profit_service import calculate_project_profit


def get_project_dashboard(
    db: Session,
    project_id: int,
):
    project = db.query(Project).filter(Project.id == project_id).first()

    if project is None:
        return None

    customer = db.query(Customer).filter(Customer.id == project.customer_id).first()

    items = db.query(ProjectItem).filter(ProjectItem.project_id == project_id).all()

    expenses = (
        db.query(ProjectExpense).filter(ProjectExpense.project_id == project_id).all()
    )

    cost_data = calculate_project_cost(
        db,
        project_id,
    )

    profit_data = calculate_project_profit(
        db,
        project_id,
    )

    total_quantity = sum(item.quantity for item in items)

    return {
        "project": {
            "id": project.id,
            "name": project.name,
            "description": project.description,
            "location": project.location,
            "status": project.status,
        },
        "customer": {
            "id": customer.id,
            "name": customer.name,
            "phone": customer.phone,
            "email": customer.email,
        },
        "items": {
            "count": len(items),
            "quantity": total_quantity,
            "total": cost_data["item_total"],
        },
        "expenses": {
            "count": len(expenses),
            "total": cost_data["expense_total"],
        },
        "financial": {
            "quoted_price": profit_data["quoted_price"],
            "total_cost": cost_data["total_cost"],
            "expected_profit": profit_data["expected_profit"],
            "profit_percentage": profit_data["profit_percentage"],
        },
    }
