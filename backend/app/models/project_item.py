from sqlalchemy import Float, ForeignKey, Integer, String
from sqlalchemy.orm import Mapped, mapped_column, relationship

from app.database.database import Base


class ProjectItem(Base):
    __tablename__ = "project_items"

    id: Mapped[int] = mapped_column(primary_key=True, index=True)

    project_id: Mapped[int] = mapped_column(
        ForeignKey("projects.id"), nullable=False, index=True
    )

    item_type: Mapped[str] = mapped_column(String(100), nullable=False)

    description: Mapped[str | None] = mapped_column(String(255), nullable=True)

    quantity: Mapped[int] = mapped_column(Integer, default=1, nullable=False)

    width: Mapped[float | None] = mapped_column(Float, nullable=True)

    height: Mapped[float | None] = mapped_column(Float, nullable=True)

    material: Mapped[str | None] = mapped_column(String(100), nullable=True)

    profile: Mapped[str | None] = mapped_column(String(100), nullable=True)

    glass_type: Mapped[str | None] = mapped_column(String(100), nullable=True)

    unit_price: Mapped[float | None] = mapped_column(Float, nullable=True)

    project = relationship("Project", back_populates="items")
