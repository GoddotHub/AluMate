from datetime import datetime, UTC
from sqlalchemy import DateTime, Float, ForeignKey, String, Text
from sqlalchemy.orm import Mapped, mapped_column, relationship
from app.database.database import Base


class Quotation(Base):
    __tablename__ = "quotations"

    id: Mapped[int] = mapped_column(primary_key=True, index=True)
    project_id: Mapped[int] = mapped_column(
        ForeignKey("projects.id"), nullable=False, index=True
    )
    quotation_number: Mapped[str] = mapped_column(
        String(50), nullable=False, unique=True, index=True
    )
    current_cost: Mapped[float] = mapped_column(Float, nullable=False)
    profit_percentage: Mapped[float] = mapped_column(Float, nullable=False)
    profit_amount: Mapped[float] = mapped_column(Float, nullable=False)
    selling_price: Mapped[float] = mapped_column(Float, nullable=False)
    status: Mapped[str] = mapped_column(String(30), default="Draft", nullable=False)
    notes: Mapped[str | None] = mapped_column(Text, nullable=True)
    created_at: Mapped[datetime] = mapped_column(
        DateTime,
        default=lambda: datetime.now(UTC),
        nullable=False,
    )

    project = relationship("Project", back_populates="quotations")
    snapshots = relationship(
        "QuotationSnapshot",
        back_populates="quotation",
        cascade="all, delete-orphan",
    )
