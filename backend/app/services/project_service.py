from sqlalchemy.orm import Session

from app.models.customer import Customer
from app.models.project import Project
from app.schemas.project import ProjectCreate, ProjectUpdate


def create_project(db: Session, project_data: ProjectCreate):
    customer = (
        db.query(Customer).filter(Customer.id == project_data.customer_id).first()
    )

    if customer is None:
        return None

    project = Project(
        customer_id=project_data.customer_id,
        name=project_data.name,
        description=project_data.description,
        location=project_data.location,
        status=project_data.status,
    )

    db.add(project)
    db.commit()
    db.refresh(project)

    return project


def get_projects(db: Session):
    return db.query(Project).all()


def get_project(db: Session, project_id: int):
    return db.query(Project).filter(Project.id == project_id).first()


def get_customer_projects(db: Session, customer_id: int):
    return db.query(Project).filter(Project.customer_id == customer_id).all()


def update_project(db: Session, project_id: int, project_data: ProjectUpdate):
    project = get_project(db, project_id)

    if project is None:
        return None

    update_data = project_data.model_dump(exclude_unset=True)

    # If customer_id is being changed, verify that
    # the new customer exists.
    if "customer_id" in update_data:
        customer = (
            db.query(Customer).filter(Customer.id == update_data["customer_id"]).first()
        )

        if customer is None:
            return "customer_not_found"

    for field, value in update_data.items():
        setattr(project, field, value)

    db.commit()
    db.refresh(project)

    return project


def delete_project(db: Session, project_id: int):
    project = get_project(db, project_id)

    if project is None:
        return None

    db.delete(project)
    db.commit()

    return project
