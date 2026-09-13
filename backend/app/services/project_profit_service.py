from sqlalchemy.orm import Session

from app.models.project import Project
from app.services.project_cost_service import calculate_project_cost


def calculate_project_profit(
    db: Session,
    project_id: int,
):
    project = db.query(Project).filter(Project.id == project_id).first()

    if project is None:
        return None

    if project.quoted_price is None:
        return {
            "project_id": project_id,
            "quoted_price": None,
            "total_cost": None,
            "expected_profit": None,
            "profit_percentage": None,
        }

    cost_data = calculate_project_cost(
        db,
        project_id,
    )

    total_cost = cost_data["total_cost"]

    expected_profit = project.quoted_price - total_cost

    if project.quoted_price == 0:
        profit_percentage = None
    else:
        profit_percentage = round((expected_profit / project.quoted_price) * 100, 2)

    return {
        "project_id": project_id,
        "quoted_price": project.quoted_price,
        "total_cost": total_cost,
        "expected_profit": expected_profit,
        "profit_percentage": profit_percentage,
    }
