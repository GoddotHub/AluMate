from pydantic import BaseModel, ConfigDict, Field


class ProjectItemCreate(BaseModel):
    project_id: int = Field(gt=0)
    item_type: str = Field(min_length=1, max_length=100)
    description: str | None = Field(default=None, max_length=255)

    quantity: int = Field(default=1, gt=0)

    width: float | None = Field(default=None, gt=0)

    height: float | None = Field(default=None, gt=0)

    material: str | None = Field(default=None, max_length=100)

    profile: str | None = Field(default=None, max_length=100)

    glass_type: str | None = Field(default=None, max_length=100)

    unit_price: float | None = Field(default=None, ge=0)


class ProjectItemUpdate(BaseModel):
    project_id: int | None = Field(default=None, gt=0)

    item_type: str | None = Field(default=None, min_length=1, max_length=100)

    description: str | None = Field(default=None, max_length=255)

    quantity: int | None = Field(default=None, gt=0)

    width: float | None = Field(default=None, gt=0)

    height: float | None = Field(default=None, gt=0)

    material: str | None = Field(default=None, max_length=100)

    profile: str | None = Field(default=None, max_length=100)

    glass_type: str | None = Field(default=None, max_length=100)

    unit_price: float | None = Field(default=None, ge=0)


class ProjectItemResponse(BaseModel):
    id: int
    project_id: int
    item_type: str
    description: str | None
    quantity: int
    width: float | None
    height: float | None
    material: str | None
    profile: str | None
    glass_type: str | None
    unit_price: float | None
    total_price: float | None

    model_config = ConfigDict(from_attributes=True)
