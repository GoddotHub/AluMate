from pydantic import BaseModel


class ProjectSummaryResponse(BaseModel):
    project_id: int
    project_name: str

    quoted_price: float | None

    item_total: float
    expense_total: float
    total_cost: float

    expected_profit: float | None
    profit_percentage: float | None

    item_count: int
    expense_count: int
