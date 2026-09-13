from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session

from app.database.database import get_db
from app.schemas.customer import CustomerCreate, CustomerResponse, CustomerUpdate
from app.services.customer_service import (
    create_customer,
    get_customer,
    get_customers,
    update_customer,
    delete_customer,
)

router = APIRouter(prefix="/customers", tags=["Customers"])


@router.post("/", response_model=CustomerResponse)
def create_customer_endpoint(
    customer_data: CustomerCreate, db: Session = Depends(get_db)
):
    return create_customer(db, customer_data)


@router.get("/", response_model=list[CustomerResponse])
def get_customers_endpoint(db: Session = Depends(get_db)):
    return get_customers(db)


@router.get("/{customer_id}", response_model=CustomerResponse)
def get_customer_endpoint(customer_id: int, db: Session = Depends(get_db)):
    customer = get_customer(db, customer_id)

    if customer is None:
        raise HTTPException(status_code=404, detail="Customer not found")

    return customer


@router.put("/{customer_id}", response_model=CustomerResponse)
def update_customer_endpoint(
    customer_id: int, customer_data: CustomerUpdate, db: Session = Depends(get_db)
):
    customer = update_customer(db, customer_id, customer_data)

    if customer is None:
        raise HTTPException(status_code=404, detail="Customer not found")

    return customer


@router.delete("/{customer_id}")
def delete_customer_endpoint(customer_id: int, db: Session = Depends(get_db)):
    customer = delete_customer(db, customer_id)

    if customer is None:
        raise HTTPException(status_code=404, detail="Customer not found")

    return {"message": "Customer deleted successfully", "customer_id": customer_id}
