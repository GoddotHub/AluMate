from fastapi import APIRouter, Depends
from sqlalchemy.orm import Session
from app.database.database import get_db
from app.services.dashboard_service import get_system_dashboard
from app.schemas.dashboard import SystemDashboardResponse

router = APIRouter(prefix="/dashboard", tags=["Dashboard"])

@router.get("/", response_model=SystemDashboardResponse)
def get_dashboard_summary(db: Session = Depends(get_db)):
    return get_system_dashboard(db)
