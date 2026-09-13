from sqlalchemy.orm import Session

from app.services.project_expense_service import (
    calculate_project_expenses_total,
)
from app.services.project_item_service import (
    calculate_project_total,
)


def calculate_project_cost(
    db: Session,
    project_id: int,
):
    item_total = calculate_project_total(
        db,
        project_id,
    )

    expense_total = calculate_project_expenses_total(
        db,
        project_id,
    )

    total_cost = item_total + expense_total

    return {
        "project_id": project_id,
        "item_total": item_total,
        "expense_total": expense_total,
        "total_cost": total_cost,
    }
