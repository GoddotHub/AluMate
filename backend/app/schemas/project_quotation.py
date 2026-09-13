from pydantic import BaseModel, Field


class ProjectQuotationRequest(BaseModel):
    profit_percentage: float = Field(gt=0, le=1000)


class ProjectQuotationResponse(BaseModel):
    project_id: int
    project_name: str

    current_cost: float

    profit_percentage: float
    profit_amount: float

    recommended_price: float
