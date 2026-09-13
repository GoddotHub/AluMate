from datetime import datetime, UTC

from sqlalchemy import DateTime, ForeignKey, Integer, JSON
from sqlalchemy.orm import Mapped, mapped_column, relationship

from app.database.database import Base


class QuotationSnapshot(Base):
    __tablename__ = "quotation_snapshots"

    id: Mapped[int] = mapped_column(
        primary_key=True,
        index=True,
    )

    quotation_id: Mapped[int] = mapped_column(
        ForeignKey("quotations.id"),
        nullable=False,
        index=True,
    )

    version: Mapped[int] = mapped_column(
        Integer,
        nullable=False,
        default=1,
    )

    snapshot_data: Mapped[dict] = mapped_column(
        JSON,
        nullable=False,
    )

    created_at: Mapped[datetime] = mapped_column(
        DateTime,
        default=lambda: datetime.now(UTC),
        nullable=False,
    )

    quotation = relationship(
        "Quotation",
        back_populates="snapshots",
    )