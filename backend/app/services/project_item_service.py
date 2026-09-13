from sqlalchemy.orm import Session

from app.models.project import Project
from app.models.project_item import ProjectItem
from app.schemas.project_item import ProjectItemCreate, ProjectItemUpdate


def calculate_total_price(item: ProjectItem):
    if item.unit_price is None:
        return None

    return item.quantity * item.unit_price


def create_project_item(db: Session, item_data: ProjectItemCreate):
    project = db.query(Project).filter(Project.id == item_data.project_id).first()

    if project is None:
        return None

    item = ProjectItem(
        project_id=item_data.project_id,
        item_type=item_data.item_type,
        description=item_data.description,
        quantity=item_data.quantity,
        width=item_data.width,
        height=item_data.height,
        material=item_data.material,
        profile=item_data.profile,
        glass_type=item_data.glass_type,
        unit_price=item_data.unit_price,
    )

    db.add(item)
    db.commit()
    db.refresh(item)

    return item


def get_project_items(db: Session):
    return db.query(ProjectItem).all()


def get_project_item(db: Session, item_id: int):
    return db.query(ProjectItem).filter(ProjectItem.id == item_id).first()


def get_items_by_project(db: Session, project_id: int):
    return db.query(ProjectItem).filter(ProjectItem.project_id == project_id).all()


def update_project_item(db: Session, item_id: int, item_data: ProjectItemUpdate):
    item = get_project_item(db, item_id)

    if item is None:
        return None

    update_data = item_data.model_dump(exclude_unset=True)

    if "project_id" in update_data:
        project = (
            db.query(Project).filter(Project.id == update_data["project_id"]).first()
        )

        if project is None:
            return "project_not_found"

    for field, value in update_data.items():
        setattr(item, field, value)

    db.commit()
    db.refresh(item)

    return item


def delete_project_item(db: Session, item_id: int):
    item = get_project_item(db, item_id)

    if item is None:
        return None

    db.delete(item)
    db.commit()

    return item


def calculate_project_total(db: Session, project_id: int):
    items = db.query(ProjectItem).filter(ProjectItem.project_id == project_id).all()

    total = 0.0

    for item in items:
        item_total = calculate_total_price(item)

        if item_total is not None:
            total += item_total

    return total
