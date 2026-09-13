from pydantic import BaseModel

class SystemDashboardResponse(BaseModel):
    total_customers: int
    total_projects: int
    total_quotations: int
    active_projects: int
    total_revenue_potential: float
