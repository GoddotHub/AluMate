from sqlalchemy.orm import Session
from app.models.customer import Customer
from app.models.project import Project
from app.models.quotation import Quotation


def get_system_dashboard(db: Session):
    total_customers = db.query(Customer).count()
    total_projects = db.query(Project).count()
    total_quotations = db.query(Quotation).count()
    active_projects = db.query(Project).filter(Project.status == "active").count()

    # Filter only approved or active quotations to avoid compounding draft revisions
    approved_quotations = (
        db.query(Quotation).filter(Quotation.status == "approved").all()
    )
    total_revenue_potential = sum(
        [q.selling_price for q in approved_quotations if q.selling_price]
    )

    return {
        "total_customers": total_customers,
        "total_projects": total_projects,
        "total_quotations": total_quotations,
        "active_projects": active_projects,
        "total_revenue_potential": total_revenue_potential,
    }
