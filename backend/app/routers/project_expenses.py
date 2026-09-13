from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session

from app.database.database import get_db
from app.schemas.project_expense import (
    ProjectExpenseCreate,
    ProjectExpenseResponse,
    ProjectExpenseUpdate,
)
from app.services.project_expense_service import (
    create_project_expense,
    delete_project_expense,
    get_expenses_by_project,
    get_project_expense,
    get_project_expenses,
    update_project_expense,
)

router = APIRouter(prefix="/project-expenses", tags=["Project Expenses"])


@router.post("/", response_model=ProjectExpenseResponse, status_code=201)
def create_project_expense_endpoint(
    expense_data: ProjectExpenseCreate, db: Session = Depends(get_db)
):
    expense = create_project_expense(db, expense_data)

    if expense is None:
        raise HTTPException(status_code=404, detail="Project not found")

    return expense


@router.get("/", response_model=list[ProjectExpenseResponse])
def get_project_expenses_endpoint(db: Session = Depends(get_db)):
    return get_project_expenses(db)


@router.get("/project/{project_id}", response_model=list[ProjectExpenseResponse])
def get_expenses_by_project_endpoint(project_id: int, db: Session = Depends(get_db)):
    return get_expenses_by_project(db, project_id)


@router.get("/{expense_id}", response_model=ProjectExpenseResponse)
def get_project_expense_endpoint(expense_id: int, db: Session = Depends(get_db)):
    expense = get_project_expense(db, expense_id)

    if expense is None:
        raise HTTPException(status_code=404, detail="Project expense not found")

    return expense


@router.put("/{expense_id}", response_model=ProjectExpenseResponse)
def update_project_expense_endpoint(
    expense_id: int, expense_data: ProjectExpenseUpdate, db: Session = Depends(get_db)
):
    expense = update_project_expense(db, expense_id, expense_data)

    if expense is None:
        raise HTTPException(status_code=404, detail="Project expense not found")

    if expense == "project_not_found":
        raise HTTPException(status_code=404, detail="Project not found")

    return expense


@router.delete("/{expense_id}")
def delete_project_expense_endpoint(expense_id: int, db: Session = Depends(get_db)):
    expense = delete_project_expense(db, expense_id)

    if expense is None:
        raise HTTPException(status_code=404, detail="Project expense not found")

    return {"message": "Project expense deleted successfully", "expense_id": expense_id}
