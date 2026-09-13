from fastapi import APIRouter, Depends, HTTPException
from fastapi.responses import StreamingResponse
from sqlalchemy.orm import Session

from app.database.database import get_db

from app.schemas.project_quotation_history import (
    ProjectQuotationHistoryResponse,
)
from app.schemas.quotation import (
    QuotationCreate,
    QuotationResponse,
    QuotationUpdate,
)
from app.schemas.quotation_snapshot import (
    QuotationSnapshotResponse,
)
from app.services.quotation_snapshot_service import (
    get_quotation_snapshots,
)

from app.services.project_quotation_history_service import (
    get_project_quotation_history,
)
from app.services.quotation_service import (
    accept_quotation,
    create_quotation,
    delete_quotation,
    get_project_quotations,
    get_quotation,
    get_quotations,
    reject_quotation,
    send_quotation,
    update_quotation,
)
from app.services.quotation_pdf_service import (
    generate_quotation_pdf,
)


router = APIRouter(
    prefix="/quotations",
    tags=["Quotations"],
)


# ============================================================
# CREATE QUOTATION
# ============================================================

@router.post(
    "/",
    response_model=QuotationResponse,
    status_code=201,
)
def create_quotation_endpoint(
    quotation_data: QuotationCreate,
    db: Session = Depends(get_db),
):
    quotation = create_quotation(
        db,
        quotation_data,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return quotation


# ============================================================
# GET ALL QUOTATIONS
# ============================================================

@router.get(
    "/",
    response_model=list[QuotationResponse],
)
def get_quotations_endpoint(
    db: Session = Depends(get_db),
):
    return get_quotations(db)


# ============================================================
# GET QUOTATION HISTORY FOR A PROJECT
# ============================================================

@router.get(
    "/project/{project_id}/history",
    response_model=ProjectQuotationHistoryResponse,
)
def get_project_quotation_history_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    history = get_project_quotation_history(
        db,
        project_id,
    )

    if history is None:
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    return history


# ============================================================
# GET ALL QUOTATIONS FOR ONE PROJECT
# ============================================================

@router.get(
    "/project/{project_id}",
    response_model=list[QuotationResponse],
)
def get_project_quotations_endpoint(
    project_id: int,
    db: Session = Depends(get_db),
):
    return get_project_quotations(
        db,
        project_id,
    )


# ============================================================
# SEND QUOTATION
# Draft → Sent
# ============================================================

@router.post(
    "/{quotation_id}/send",
    response_model=QuotationResponse,
)
def send_quotation_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = send_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    if quotation is False:
        raise HTTPException(
            status_code=400,
            detail="Only Draft quotations can be sent",
        )

    return quotation


# ============================================================
# ACCEPT QUOTATION
# Sent → Accepted
# ============================================================

@router.post(
    "/{quotation_id}/accept",
    response_model=QuotationResponse,
)
def accept_quotation_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = accept_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    if quotation == "already_accepted":
        raise HTTPException(
            status_code=400,
            detail="This project already has an accepted quotation",
        )

    if quotation == "project_not_found":
        raise HTTPException(
            status_code=404,
            detail="Project not found",
        )

    if quotation is False:
        raise HTTPException(
            status_code=400,
            detail="Only Sent quotations can be accepted",
        )

    return quotation


# ============================================================
# REJECT QUOTATION
# Sent → Rejected
# ============================================================

@router.post(
    "/{quotation_id}/reject",
    response_model=QuotationResponse,
)
def reject_quotation_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = reject_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    if quotation is False:
        raise HTTPException(
            status_code=400,
            detail="Only Sent quotations can be rejected",
        )

    return quotation
    
    
# ============================================================
# DOWNLOAD QUOTATION PDF
# ============================================================

@router.get(
    "/{quotation_id}/pdf",
)
def download_quotation_pdf_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    pdf_buffer = generate_quotation_pdf(
        db,
        quotation_id,
    )

    if pdf_buffer is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    return StreamingResponse(
        pdf_buffer,
        media_type="application/pdf",
        headers={
            "Content-Disposition": (
                f"attachment; filename=quotation-{quotation_id}.pdf"
            )
        },
    )


# ============================================================
# GET ONE QUOTATION
# ============================================================

@router.get(
    "/{quotation_id}",
    response_model=QuotationResponse,
)
def get_quotation_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = get_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    return quotation
 
# ============================================================   
# GET QUOTATION SNAPSHOT HISTORY
# ============================================================
@router.get(
    "/{quotation_id}/snapshots",
    response_model=list[QuotationSnapshotResponse],
)
def get_quotation_snapshots_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = get_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    return get_quotation_snapshots(
        db,
        quotation_id,
    )


# ============================================================
# UPDATE QUOTATION
# ============================================================

@router.put(
    "/{quotation_id}",
    response_model=QuotationResponse,
)
def update_quotation_endpoint(
    quotation_id: int,
    quotation_data: QuotationUpdate,
    db: Session = Depends(get_db),
):
    quotation = update_quotation(
        db,
        quotation_id,
        quotation_data,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    return quotation


# ============================================================
# DELETE QUOTATION
# ============================================================

@router.delete(
    "/{quotation_id}",
)
def delete_quotation_endpoint(
    quotation_id: int,
    db: Session = Depends(get_db),
):
    quotation = delete_quotation(
        db,
        quotation_id,
    )

    if quotation is None:
        raise HTTPException(
            status_code=404,
            detail="Quotation not found",
        )

    return {
        "message": "Quotation deleted successfully",
        "quotation_id": quotation_id,
    }
    