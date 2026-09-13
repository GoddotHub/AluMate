from pydantic import BaseModel, ConfigDict
from datetime import datetime
from typing import Optional


class ProjectProgressBase(BaseModel):
    milestone_name: str
    status: str = "Pending"
    completion_percentage: int = 0
    notes: Optional[str] = None


class ProjectProgressCreate(ProjectProgressBase):
    pass


class ProjectProgressResponse(ProjectProgressBase):
    id: int
    project_id: int
    updated_at: datetime

    model_config = ConfigDict(from_attributes=True)
