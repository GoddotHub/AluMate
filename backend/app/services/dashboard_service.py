from sqlalchemy.orm import Session
from app.models.customer import Customer
from app.models.project import Project
from app.models.quotation import Quotation

def get_system_dashboard(db: Session):
    total_customers = db.query(Customer).count()
    total_projects = db.query(Project).count()
    total_quotations = db.query(Quotation).count()
    active_projects = db.query(Project).filter(Project.status == "active").count()
    
    quotations = db.query(Quotation).all()
    total_revenue_potential = sum([q.selling_price for q in quotations if hasattr(q, 'selling_price') and q.selling_price])

    return {
        "total_customers": total_customers,
        "total_projects": total_projects,
        "total_quotations": total_quotations,
        "active_projects": active_projects,
        "total_revenue_potential": total_revenue_potential
    }
