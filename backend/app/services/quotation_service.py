from sqlalchemy.orm import Session

from app.models.project import Project
from app.models.quotation import Quotation
from app.schemas.quotation import QuotationCreate, QuotationUpdate
from app.services.project_quotation_service import calculate_project_quotation
from app.services.quotation_snapshot_service import (
    create_quotation_snapshot,
)


def generate_quotation_number(db: Session):
    quotation_count = db.query(Quotation).count()
    next_number = quotation_count + 1

    return f"QUO-{next_number:05d}"


def create_quotation(
    db: Session,
    quotation_data: QuotationCreate,
):
    project = (
        db.query(Project)
        .filter(Project.id == quotation_data.project_id)
        .first()
    )

    if project is None:
        return None

    calculation = calculate_project_quotation(
        db,
        quotation_data.project_id,
        quotation_data,
    )

    quotation = Quotation(
        project_id=quotation_data.project_id,
        quotation_number=generate_quotation_number(db),
        current_cost=calculation["current_cost"],
        profit_percentage=calculation["profit_percentage"],
        profit_amount=calculation["profit_amount"],
        selling_price=calculation["recommended_price"],
        status="Draft",
        notes=quotation_data.notes,
    )

    db.add(quotation)

    # Make the quotation available to the snapshot service
    # before committing the transaction.
    db.flush()

    create_quotation_snapshot(
        db,
        quotation,
    )

    db.commit()
    db.refresh(quotation)

    return quotation


def get_quotations(db: Session):
    return db.query(Quotation).all()


def get_project_quotations(
    db: Session,
    project_id: int,
):
    return db.query(Quotation).filter(Quotation.project_id == project_id).all()


def get_quotation(
    db: Session,
    quotation_id: int,
):
    return db.query(Quotation).filter(Quotation.id == quotation_id).first()


def update_quotation(
    db: Session,
    quotation_id: int,
    quotation_data: QuotationUpdate,
):
    quotation = get_quotation(db, quotation_id)

    if quotation is None:
        return None

    update_data = quotation_data.model_dump(
        exclude_unset=True,
    )

    if "profit_percentage" in update_data:
        calculation_data = QuotationCreate(
            project_id=quotation.project_id,
            profit_percentage=update_data["profit_percentage"],
            notes=quotation.notes,
        )

        calculation = calculate_project_quotation(
            db,
            quotation.project_id,
            calculation_data,
        )

        quotation.current_cost = calculation["current_cost"]
        quotation.profit_percentage = calculation["profit_percentage"]
        quotation.profit_amount = calculation["profit_amount"]
        quotation.selling_price = calculation["recommended_price"]

        del update_data["profit_percentage"]

    for field, value in update_data.items():
        setattr(quotation, field, value)

    db.flush()

    create_quotation_snapshot(
        db,
        quotation,
    )

    db.commit()
    db.refresh(quotation)

    return quotation


def delete_quotation(
    db: Session,
    quotation_id: int,
):
    quotation = get_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        return None

    db.delete(quotation)
    db.commit()

    return quotation


def send_quotation(db: Session, quotation_id: int):
    quotation = get_quotation(db, quotation_id)

    if quotation is None:
        return None

    if quotation.status != "Draft":
        return False

    quotation.status = "Sent"

    db.commit()
    db.refresh(quotation)

    return quotation


def accept_quotation(db: Session, quotation_id: int):
    quotation = get_quotation(db, quotation_id)

    if quotation is None:
        return None

    if quotation.status != "Sent":
        return False

    existing_accepted_quotation = (
        db.query(Quotation)
        .filter(
            Quotation.project_id == quotation.project_id,
            Quotation.status == "Accepted",
        )
        .first()
    )

    if existing_accepted_quotation is not None:
        return "already_accepted"

    project = (
        db.query(Project)
        .filter(Project.id == quotation.project_id)
        .first()
    )

    if project is None:
        return "project_not_found"

    quotation.status = "Accepted"
    project.quoted_price = quotation.selling_price

    db.commit()
    db.refresh(quotation)

    return quotation


def reject_quotation(db: Session, quotation_id: int):
    quotation = get_quotation(db, quotation_id)

    if quotation is None:
        return None

    if quotation.status != "Sent":
        return False

    quotation.status = "Rejected"

    db.commit()
    db.refresh(quotation)

    return quotation
    
    
# AluMate quotation lifecycle
