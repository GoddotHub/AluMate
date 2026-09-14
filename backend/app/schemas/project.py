from datetime import datetime

from pydantic import BaseModel, ConfigDict, Field


class ProjectCreate(BaseModel):
    customer_id: int = Field(gt=0)

    name: str = Field(min_length=1, max_length=150)

    description: str | None = Field(default=None, max_length=1000)

    location: str | None = Field(default=None, max_length=200)

    status: str = Field(default="Planning", max_length=50)

    quoted_price: float | None = Field(default=None, ge=0)


class ProjectUpdate(BaseModel):
    customer_id: int | None = Field(default=None, gt=0)

    name: str | None = Field(default=None, min_length=1, max_length=150)

    description: str | None = Field(default=None, max_length=1000)

    location: str | None = Field(default=None, max_length=200)

    status: str | None = Field(default=None, max_length=50)

    quoted_price: float | None = Field(default=None, ge=0)


class ProjectResponse(BaseModel):
    id: int
    customer_id: int
    customer_name: str | None = None  # Human-readable company name
    name: str
    description: str | None = None
    location: str | None = None  # e.g., "Ibadan"
    status: str
    quoted_price: float | None = None  # e.g., 3450000.00
    created_at: datetime
    updated_at: datetime

    model_config = ConfigDict(from_attributes=True)
