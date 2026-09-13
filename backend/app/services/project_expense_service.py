from sqlalchemy.orm import Session

from app.models.project import Project
from app.models.project_expense import ProjectExpense
from app.schemas.project_expense import ProjectExpenseCreate, ProjectExpenseUpdate


def create_project_expense(db: Session, expense_data: ProjectExpenseCreate):
    project = db.query(Project).filter(Project.id == expense_data.project_id).first()

    if project is None:
        return None

    expense = ProjectExpense(
        project_id=expense_data.project_id,
        expense_type=expense_data.expense_type,
        description=expense_data.description,
        amount=expense_data.amount,
    )

    db.add(expense)
    db.commit()
    db.refresh(expense)

    return expense


def get_project_expenses(db: Session):
    return db.query(ProjectExpense).all()


def get_project_expense(db: Session, expense_id: int):
    return db.query(ProjectExpense).filter(ProjectExpense.id == expense_id).first()


def get_expenses_by_project(db: Session, project_id: int):
    return (
        db.query(ProjectExpense).filter(ProjectExpense.project_id == project_id).all()
    )


def update_project_expense(
    db: Session, expense_id: int, expense_data: ProjectExpenseUpdate
):
    expense = get_project_expense(db, expense_id)

    if expense is None:
        return None

    update_data = expense_data.model_dump(exclude_unset=True)

    if "project_id" in update_data:
        project = (
            db.query(Project).filter(Project.id == update_data["project_id"]).first()
        )

        if project is None:
            return "project_not_found"

    for field, value in update_data.items():
        setattr(expense, field, value)

    db.commit()
    db.refresh(expense)

    return expense


def delete_project_expense(db: Session, expense_id: int):
    expense = get_project_expense(db, expense_id)

    if expense is None:
        return None

    db.delete(expense)
    db.commit()

    return expense


def calculate_project_expenses_total(db: Session, project_id: int):
    expenses = (
        db.query(ProjectExpense).filter(ProjectExpense.project_id == project_id).all()
    )

    total = 0.0

    for expense in expenses:
        total += expense.amount

    return total
