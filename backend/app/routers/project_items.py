from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session

from app.database.database import get_db
from app.schemas.project_item import (
    ProjectItemCreate,
    ProjectItemResponse,
    ProjectItemUpdate,
)
from app.services.project_item_service import (
    calculate_total_price,
    create_project_item,
    delete_project_item,
    get_items_by_project,
    get_project_item,
    get_project_items,
    update_project_item,
)

router = APIRouter(prefix="/project-items", tags=["Project Items"])


def project_item_response(item):
    return {
        "id": item.id,
        "project_id": item.project_id,
        "item_type": item.item_type,
        "description": item.description,
        "quantity": item.quantity,
        "width": item.width,
        "height": item.height,
        "material": item.material,
        "profile": item.profile,
        "glass_type": item.glass_type,
        "unit_price": item.unit_price,
        "total_price": calculate_total_price(item),
    }


@router.post("/", response_model=ProjectItemResponse, status_code=201)
def create_project_item_endpoint(
    item_data: ProjectItemCreate, db: Session = Depends(get_db)
):
    item = create_project_item(db, item_data)

    if item is None:
        raise HTTPException(status_code=404, detail="Project not found")

    return project_item_response(item)


@router.get("/", response_model=list[ProjectItemResponse])
def get_project_items_endpoint(db: Session = Depends(get_db)):
    items = get_project_items(db)

    return [project_item_response(item) for item in items]


@router.get("/project/{project_id}", response_model=list[ProjectItemResponse])
def get_items_by_project_endpoint(project_id: int, db: Session = Depends(get_db)):
    items = get_items_by_project(db, project_id)

    return [project_item_response(item) for item in items]


@router.get("/{item_id}", response_model=ProjectItemResponse)
def get_project_item_endpoint(item_id: int, db: Session = Depends(get_db)):
    item = get_project_item(db, item_id)

    if item is None:
        raise HTTPException(status_code=404, detail="Project item not found")

    return project_item_response(item)


@router.put("/{item_id}", response_model=ProjectItemResponse)
def update_project_item_endpoint(
    item_id: int, item_data: ProjectItemUpdate, db: Session = Depends(get_db)
):
    item = update_project_item(db, item_id, item_data)

    if item is None:
        raise HTTPException(status_code=404, detail="Project item not found")

    if item == "project_not_found":
        raise HTTPException(status_code=404, detail="Project not found")

    return project_item_response(item)


@router.delete("/{item_id}")
def delete_project_item_endpoint(item_id: int, db: Session = Depends(get_db)):
    item = delete_project_item(db, item_id)

    if item is None:
        raise HTTPException(status_code=404, detail="Project item not found")

    return {"message": "Project item deleted successfully", "item_id": item_id}
