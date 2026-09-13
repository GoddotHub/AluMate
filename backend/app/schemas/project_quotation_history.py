from pydantic import BaseModel

from app.schemas.quotation import QuotationResponse


class ProjectQuotationHistoryResponse(BaseModel):
    project_id: int
    project_name: str

    total_quotations: int
    draft_count: int
    sent_count: int
    accepted_count: int
    rejected_count: int

    current_price: float | None

    quotations: list[QuotationResponse]
