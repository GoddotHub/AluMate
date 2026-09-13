from sqlalchemy.orm import Session

from app.models.project import Project
from app.models.project_expense import ProjectExpense
from app.models.project_item import ProjectItem

from app.services.project_cost_service import calculate_project_cost

from app.services.project_profit_service import calculate_project_profit


def get_project_summary(
    db: Session,
    project_id: int,
):
    project = db.query(Project).filter(Project.id == project_id).first()

    if project is None:
        return None

    cost_data = calculate_project_cost(
        db,
        project_id,
    )

    profit_data = calculate_project_profit(
        db,
        project_id,
    )

    items = db.query(ProjectItem).filter(ProjectItem.project_id == project_id).all()

    expenses = (
        db.query(ProjectExpense).filter(ProjectExpense.project_id == project_id).all()
    )

    item_count = sum(item.quantity for item in items)

    expense_count = len(expenses)

    return {
        "project_id": project.id,
        "project_name": project.name,
        "quoted_price": project.quoted_price,
        "item_total": cost_data["item_total"],
        "expense_total": cost_data["expense_total"],
        "total_cost": cost_data["total_cost"],
        "expected_profit": profit_data["expected_profit"],
        "profit_percentage": profit_data["profit_percentage"],
        "item_count": item_count,
        "expense_count": expense_count,
    }
