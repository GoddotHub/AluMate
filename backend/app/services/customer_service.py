from sqlalchemy.orm import Session

from app.models.customer import Customer
from app.schemas.customer import CustomerCreate, CustomerUpdate


def create_customer(db: Session, customer_data: CustomerCreate):
    customer = Customer(
        name=customer_data.name, phone=customer_data.phone, email=customer_data.email
    )

    db.add(customer)
    db.commit()
    db.refresh(customer)

    return customer


def get_customers(db: Session):
    return db.query(Customer).all()


def get_customer(db: Session, customer_id: int):
    return db.query(Customer).filter(Customer.id == customer_id).first()


def update_customer(db: Session, customer_id: int, customer_data: CustomerUpdate):
    customer = get_customer(db, customer_id)

    if customer is None:
        return None

    update_data = customer_data.model_dump(exclude_unset=True)

    for field, value in update_data.items():
        setattr(customer, field, value)

    db.commit()
    db.refresh(customer)

    return customer


# Inside app/services/customer_service.py -> delete_customer function
def delete_customer(db: Session, customer_id: int):
    customer = db.query(Customer).filter(Customer.id == customer_id).first()
    if customer:
        # Delete related projects first if needed to prevent integrity errors
        for project in customer.projects:
            db.delete(project)
        db.delete(customer)
        db.commit()
    return customer
