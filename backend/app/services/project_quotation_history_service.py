from sqlalchemy.orm import Session

from app.models.project import Project
from app.models.quotation import Quotation


def get_project_quotation_history(
    db: Session,
    project_id: int,
):
    project = (
        db.query(Project)
        .filter(Project.id == project_id)
        .first()
    )

    if project is None:
        return None

    quotations = (
        db.query(Quotation)
        .filter(Quotation.project_id == project_id)
        .order_by(Quotation.created_at.desc())
        .all()
    )

    draft_count = sum(
        quotation.status == "Draft"
        for quotation in quotations
    )

    sent_count = sum(
        quotation.status == "Sent"
        for quotation in quotations
    )

    accepted_count = sum(
        quotation.status == "Accepted"
        for quotation in quotations
    )

    rejected_count = sum(
        quotation.status == "Rejected"
        for quotation in quotations
    )

    return {
        "project_id": project.id,
        "project_name": project.name,
        "total_quotations": len(quotations),
        "draft_count": draft_count,
        "sent_count": sent_count,
        "accepted_count": accepted_count,
        "rejected_count": rejected_count,
        "current_price": project.quoted_price,
        "quotations": quotations,
    }
