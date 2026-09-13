from datetime import datetime, UTC

from sqlalchemy import DateTime, Float, ForeignKey, Integer, String, Text
from sqlalchemy.orm import Mapped, mapped_column, relationship

from app.database.database import Base


class Project(Base):
    __tablename__ = "projects"

    id: Mapped[int] = mapped_column(primary_key=True, index=True)

    customer_id: Mapped[int] = mapped_column(
        ForeignKey("customers.id"), nullable=False, index=True
    )

    name: Mapped[str] = mapped_column(String(150), nullable=False)

    description: Mapped[str | None] = mapped_column(Text, nullable=True)

    location: Mapped[str | None] = mapped_column(String(200), nullable=True)

    status: Mapped[str] = mapped_column(String(50), default="Planning", nullable=False)

    quoted_price: Mapped[float | None] = mapped_column(Float, nullable=True)

    created_at: Mapped[datetime] = mapped_column(
        DateTime,
        default=lambda: datetime.now(UTC),
        nullable=False,
    )

    updated_at: Mapped[datetime] = mapped_column(
        DateTime,
        default=lambda: datetime.now(UTC),
        onupdate=lambda: datetime.now(UTC),
        nullable=False,
    )

    customer = relationship("Customer", back_populates="projects")

    items = relationship(
        "ProjectItem", back_populates="project", cascade="all, delete-orphan"
    )

    expenses = relationship(
        "ProjectExpense", back_populates="project", cascade="all, delete-orphan"
    )

    quotations = relationship(
        "Quotation", back_populates="project", cascade="all, delete-orphan"
    )

    progress_records = relationship(
        "ProjectProgress", back_populates="project", cascade="all, delete-orphan"
    )
