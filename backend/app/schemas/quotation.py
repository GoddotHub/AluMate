from datetime import datetime

from pydantic import BaseModel, ConfigDict, Field


class QuotationCreate(BaseModel):
    project_id: int = Field(gt=0)
    profit_percentage: float = Field(gt=0, le=1000)
    notes: str | None = Field(
        default=None,
        max_length=2000,
    )


class QuotationUpdate(BaseModel):
    profit_percentage: float | None = Field(
        default=None,
        gt=0,
        le=1000,
    )
    status: str | None = Field(
        default=None,
        max_length=30,
    )
    notes: str | None = Field(
        default=None,
        max_length=2000,
    )


class QuotationResponse(BaseModel):
    id: int
    project_id: int
    quotation_number: str
    current_cost: float
    profit_percentage: float
    profit_amount: float
    selling_price: float
    status: str
    notes: str | None
    created_at: datetime

    model_config = ConfigDict(from_attributes=True)
