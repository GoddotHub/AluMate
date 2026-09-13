from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session

from app.database.database import get_db
from app.schemas.project import (
    ProjectCreate,
    ProjectResponse,
    ProjectUpdate,
)
from app.schemas.project_summary import ProjectSummaryResponse
from app.schemas.project_dashboard import ProjectDashboardResponse
from app.schemas.project_quotation import (
    ProjectQuotationRequest,
    ProjectQuotationResponse,
)

from app.services.project_quotation_service import (calculate_project_quotation,)
from app.services.project_dashboard_service import get_project_dashboard
from app.services.project_summary_service import get_project_summary
from app.services.project_cost_service import calculate_project_cost
from app.services.project_item_service import calculate_project_total
from app.services.project_profit_service import calculate_project_profit
from app.services.project_service import (
    create_project,
    delete_project,
    get_customer_projects,
    get_project,
    get_projects,
    update_project,
)

router = APIRouter(
    prefix="/projects",
    tags=["Projects"],
)


@router.post(
    "/",
    response_model=ProjectResponse,
    status_code=201,
)
def create_project_endpoint(
    project_data: ProjectCreate,
    db: Session = Depends(get_db),
):
    project = create_project(
        db,
        project_data,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Customer not found",
        )

    return project


@router.get(
    "/",
    response_model=list[ProjectResponse],
)
def get_projects_endpoint(
    db: Session = Depends(get_db),
):
    return get_projects(db)


@router.get(
    "/customer/{customer_id}",
    response_model=list[ProjectResponse],
)
def get_customer_projects_endpoint(
    customer_id: int,
    db: Session = Depends(get_db),
):
    return get_customer_projects(
        db,
        customer_id,
    )


# Specific routes must come before "/{project_id}".


@router.get("/{project_id}/total")
def get_project_total_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    project = get_project(
        db,
        project_id,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    total = calculate_project_total(
        db,
        project_id,
    )

    return {
        "project_id": project_id,
        "total": total,
    }


@router.get("/{project_id}/cost")
def get_project_cost_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    project = get_project(
        db,
        project_id,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return calculate_project_cost(
        db,
        project_id,
    )


@router.get("/{project_id}/profit")
def get_project_profit_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    profit_data = calculate_project_profit(
        db,
        project_id,
    )

    if profit_data is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return profit_data


@router.get(
    "/{project_id}/summary",
    response_model=ProjectSummaryResponse,
)
def get_project_summary_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    summary = get_project_summary(
        db,
        project_id,
    )

    if summary is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return summary


@router.get(
    "/{project_id}/dashboard",
    response_model=ProjectDashboardResponse,
)
def get_project_dashboard_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    dashboard = get_project_dashboard(
        db,
        project_id,
    )

    if dashboard is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return dashboard


@router.post(
    "/{project_id}/quotation",
    response_model=ProjectQuotationResponse,
)
def calculate_project_quotation_endpoint(
    project_id: int,
    quotation_data: ProjectQuotationRequest,
    db: Session = Depends(get_db),
):
    quotation = calculate_project_quotation(
        db,
        project_id,
        quotation_data,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return quotation


@router.get(
    "/{project_id}",
    response_model=ProjectResponse,
)
def get_project_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    project = get_project(
        db,
        project_id,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return project


@router.put(
    "/{project_id}",
    response_model=ProjectResponse,
)
def update_project_endpoint(
    project_id: int,
    project_data: ProjectUpdate,
    db: Session = Depends(get_db),
):
    project = update_project(
        db,
        project_id,
        project_data,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    if project == "customer_not_found":
        raise HTTPException(
            status_code=404,
            detail="Customer not found",
        )

    return project


@router.delete("/{project_id}")
def delete_project_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    project = delete_project(
        db,
        project_id,
    )

    if project is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return {
        "message": "Project deleted successfully",
        "project_id": project_id,
    }
