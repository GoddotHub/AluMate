from datetime import datetime

from pydantic import BaseModel, ConfigDict


class QuotationSnapshotResponse(BaseModel):
    id: int
    quotation_id: int
    version: int
    snapshot_data: dict
    created_at: datetime

    model_config = ConfigDict(from_attributes=True)
