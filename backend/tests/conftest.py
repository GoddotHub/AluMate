import pytest

from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker
from sqlalchemy.pool import StaticPool

from app.database.database import Base

# Import all models
from app.models.customer import Customer
from app.models.project import Project
from app.models.project_item import ProjectItem
from app.models.project_expense import ProjectExpense
from app.models.quotation import Quotation
from app.models.quotation_snapshot import QuotationSnapshot
from app.models.project_progress import ProjectProgress


@pytest.fixture
def db():
    engine = create_engine(
        "sqlite://",
        connect_args={"check_same_thread": False},
        poolclass=StaticPool,
    )

    Base.metadata.create_all(bind=engine)

    print(Base.metadata.tables.keys())

    TestingSessionLocal = sessionmaker(
        autocommit=False,
        autoflush=False,
        bind=engine,
    )

    session = TestingSessionLocal()

    try:
        yield session
    finally:
        session.close()
        Base.metadata.drop_all(bind=engine)
