from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session
from typing import List

from app.database.database import get_db
from app.models.project_progress import ProjectProgress
from app.models.project import Project
from app.schemas.project_progress import ProjectProgressCreate, ProjectProgressResponse

router = APIRouter(prefix="/projects", tags=["Project Progress"])


@router.get("/{project_id}/progress", response_model=List[ProjectProgressResponse])
def get_project_progress(project_id: int, db: Session = Depends(get_db)):
    project = db.query(Project).filter(Project.id == project_id).first()
    if not project:
        raise HTTPException(status_code=404, detail="Project not found")

    return (
        db.query(ProjectProgress).filter(ProjectProgress.project_id == project_id).all()
    )


@router.post("/{project_id}/progress", response_model=ProjectProgressResponse)
def create_project_progress(
    project_id: int, progress: ProjectProgressCreate, db: Session = Depends(get_db)
):
    project = db.query(Project).filter(Project.id == project_id).first()
    if not project:
        raise HTTPException(status_code=404, detail="Project not found")

    db_progress = ProjectProgress(
        project_id=project_id,
        milestone_name=progress.milestone_name,
        status=progress.status,
        completion_percentage=progress.completion_percentage,
        notes=progress.notes,
    )

    db.add(db_progress)
    db.commit()
    db.refresh(db_progress)
    return db_progress
