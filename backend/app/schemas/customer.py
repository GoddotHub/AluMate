from pydantic import BaseModel, ConfigDict


class CustomerCreate(BaseModel):
    name: str
    phone: str | None = None
    email: str | None = None


class CustomerUpdate(BaseModel):
    name: str | None = None
    phone: str | None = None
    email: str | None = None


class CustomerResponse(BaseModel):
    id: int
    name: str
    phone: str | None
    email: str | None

    model_config = ConfigDict(from_attributes=True)
