from pydantic import BaseModel, ConfigDict, Field


class ProjectExpenseCreate(BaseModel):
    project_id: int = Field(gt=0)

    expense_type: str = Field(min_length=1, max_length=100)

    description: str | None = Field(default=None, max_length=255)

    amount: float = Field(ge=0)


class ProjectExpenseUpdate(BaseModel):
    project_id: int | None = Field(default=None, gt=0)

    expense_type: str | None = Field(default=None, min_length=1, max_length=100)

    description: str | None = Field(default=None, max_length=255)

    amount: float | None = Field(default=None, ge=0)


class ProjectExpenseResponse(BaseModel):
    id: int
    project_id: int
    expense_type: str
    description: str | None
    amount: float

    model_config = ConfigDict(from_attributes=True)
