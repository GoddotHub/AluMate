from sqlalchemy.orm import Session

from app.models.project import Project
from app.services.project_cost_service import calculate_project_cost
from app.schemas.project_quotation import ProjectQuotationRequest


def calculate_project_quotation(
    db: Session,
    project_id: int,
    quotation_data: ProjectQuotationRequest,
):
    project = db.query(Project).filter(Project.id == project_id).first()

    if project is None:
        return None

    cost_data = calculate_project_cost(
        db,
        project_id,
    )

    current_cost = cost_data["total_cost"]

    profit_amount = current_cost * quotation_data.profit_percentage / 100

    recommended_price = current_cost + profit_amount

    return {
        "project_id": project.id,
        "project_name": project.name,
        "current_cost": current_cost,
        "profit_percentage": quotation_data.profit_percentage,
        "profit_amount": round(profit_amount, 2),
        "recommended_price": round(recommended_price, 2),
    }
