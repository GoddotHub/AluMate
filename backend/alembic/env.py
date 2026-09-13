from logging.config import fileConfig

from alembic import context
from sqlalchemy import engine_from_config, pool

from app.database.database import Base
from app.models.customer import Customer
from app.models.project import Project
from app.models.project_expense import ProjectExpense
from app.models.project_item import ProjectItem
from app.models.quotation import Quotation

# Alembic Config object
config = context.config


# Configure Python logging from alembic.ini
if config.config_file_name is not None:
    fileConfig(config.config_file_name)


# SQLAlchemy metadata used by Alembic
# for automatic migration generation.
target_metadata = Base.metadata


def run_migrations_offline() -> None:
    """
    Run migrations in offline mode.

    Offline mode generates SQL statements without
    establishing a database connection.
    """
    url = config.get_main_option("sqlalchemy.url")

    context.configure(
        url=url,
        target_metadata=target_metadata,
        literal_binds=True,
        dialect_opts={"paramstyle": "named"},
    )

    with context.begin_transaction():
        context.run_migrations()


def run_migrations_online() -> None:
    """
    Run migrations in online mode.

    Online mode creates a database engine and
    applies migrations directly to the database.
    """
    connectable = engine_from_config(
        config.get_section(config.config_ini_section, {}),
        prefix="sqlalchemy.",
        poolclass=pool.NullPool,
    )

    with connectable.connect() as connection:
        context.configure(
            connection=connection,
            target_metadata=target_metadata,
        )

        with context.begin_transaction():
            context.run_migrations()


if context.is_offline_mode():
    run_migrations_offline()
else:
    run_migrations_online()
