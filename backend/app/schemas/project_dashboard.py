from pydantic import BaseModel


class ProjectDashboardInfo(BaseModel):
    id: int
    name: str
    description: str | None
    location: str | None
    status: str


class CustomerDashboardInfo(BaseModel):
    id: int
    name: str
    phone: str | None
    email: str | None


class ItemsDashboardInfo(BaseModel):
    count: int
    quantity: int
    total: float


class ExpensesDashboardInfo(BaseModel):
    count: int
    total: float


class FinancialDashboardInfo(BaseModel):
    quoted_price: float | None
    total_cost: float | None
    expected_profit: float | None
    profit_percentage: float | None


class ProjectDashboardResponse(BaseModel):
    project: ProjectDashboardInfo
    customer: CustomerDashboardInfo
    items: ItemsDashboardInfo
    expenses: ExpensesDashboardInfo
    financial: FinancialDashboardInfo
