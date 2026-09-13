from sqlalchemy.orm import Session

from app.models.quotation import Quotation
from app.models.quotation_snapshot import QuotationSnapshot


def build_quotation_snapshot_data(
    quotation: Quotation,
) -> dict:
    project = quotation.project
    customer = project.customer

    return {
        "quotation": {
            "id": quotation.id,
            "quotation_number": quotation.quotation_number,
            "current_cost": quotation.current_cost,
            "profit_percentage": quotation.profit_percentage,
            "profit_amount": quotation.profit_amount,
            "selling_price": quotation.selling_price,
            "status": quotation.status,
            "notes": quotation.notes,
            "created_at": quotation.created_at.isoformat(),
        },
        "project": {
            "id": project.id,
            "name": project.name,
            "description": project.description,
            "location": project.location,
        },
        "customer": {
            "id": customer.id,
            "name": customer.name,
            "phone": customer.phone,
            "email": customer.email,
        },
        "items": [
            {
                "id": item.id,
                "item_type": item.item_type,
                "description": item.description,
                "quantity": item.quantity,
                "width": item.width,
                "height": item.height,
                "material": item.material,
                "profile": item.profile,
                "glass_type": item.glass_type,
                "unit_price": item.unit_price,
            }
            for item in project.items
        ],
        "expenses": [
            {
                "id": expense.id,
                "expense_type": expense.expense_type,
                "description": expense.description,
                "amount": expense.amount,
            }
            for expense in project.expenses
        ],
    }


def create_quotation_snapshot(
    db: Session,
    quotation: Quotation,
) -> QuotationSnapshot:
    latest_snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id,
        )
        .order_by(
            QuotationSnapshot.version.desc(),
        )
        .first()
    )

    next_version = (
        latest_snapshot.version + 1
        if latest_snapshot
        else 1
    )

    snapshot = QuotationSnapshot(
        quotation_id=quotation.id,
        version=next_version,
        snapshot_data=build_quotation_snapshot_data(quotation),
    )

    db.add(snapshot)
    db.flush()

    return snapshot
    
    
def get_quotation_snapshots(
    db: Session,
    quotation_id: int,
):
    return (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation_id,
        )
        .order_by(
            QuotationSnapshot.version.desc(),
        )
        .all()
    )
