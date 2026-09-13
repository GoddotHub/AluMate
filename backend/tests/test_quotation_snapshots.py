from app.models.customer import Customer
from app.models.project import Project
from app.models.project_item import ProjectItem
from app.models.project_expense import ProjectExpense
from app.models.quotation_snapshot import QuotationSnapshot
from app.schemas.quotation import QuotationCreate
from app.services.quotation_service import create_quotation


def create_test_project(db):
    customer = Customer(
        name="Test Customer",
        phone="08000000000",
        email="test@example.com",
    )

    db.add(customer)
    db.flush()

    project = Project(
        customer_id=customer.id,
        name="Test Aluminum Project",
        description="Snapshot test project",
        location="Ibadan",
    )

    db.add(project)
    db.flush()

    item = ProjectItem(
        project_id=project.id,
        item_type="Sliding Window",
        description="Test sliding window",
        quantity=2,
        width=1200,
        height=1500,
        material="Aluminum",
        profile="2-inch Sliding",
        glass_type="5mm Clear",
        unit_price=90000,
    )

    expense = ProjectExpense(
        project_id=project.id,
        expense_type="Labour",
        description="Test labour",
        amount=150000,
    )

    db.add(item)
    db.add(expense)

    db.commit()
    db.refresh(project)

    return project


def test_create_quotation_creates_snapshot(db):
    project = create_test_project(db)

    quotation_data = QuotationCreate(
        project_id=project.id,
        profit_percentage=25,
        notes="Snapshot test",
    )

    quotation = create_quotation(
        db,
        quotation_data,
    )

    assert quotation is not None

    snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .first()
    )

    assert snapshot is not None
    assert snapshot.version == 1

    data = snapshot.snapshot_data

    assert data["quotation"]["quotation_number"] == (
        quotation.quotation_number
    )

    assert data["project"]["name"] == (
        project.name
    )

    assert data["customer"]["name"] == (
        project.customer.name
    )


def test_snapshot_contains_items_and_expenses(db):
    project = create_test_project(db)

    quotation_data = QuotationCreate(
        project_id=project.id,
        profit_percentage=25,
    )

    quotation = create_quotation(
        db,
        quotation_data,
    )

    snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .first()
    )

    assert snapshot is not None

    data = snapshot.snapshot_data

    assert "items" in data
    assert "expenses" in data

    assert len(data["items"]) == 1
    assert len(data["expenses"]) == 1

    assert data["items"][0]["item_type"] == "Sliding Window"
    assert data["items"][0]["quantity"] == 2

    assert data["expenses"][0]["expense_type"] == "Labour"
    assert data["expenses"][0]["amount"] == 150000

    
def test_snapshot_remains_unchanged_after_project_changes(db):
    project = create_test_project(db)

    quotation_data = QuotationCreate(
        project_id=project.id,
        profit_percentage=25,
    )

    quotation = create_quotation(
        db,
        quotation_data,
    )

    snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .first()
    )

    assert snapshot is not None

    original_project_name = snapshot.snapshot_data["project"]["name"]
    original_item_price = snapshot.snapshot_data["items"][0]["unit_price"]
    original_expense = snapshot.snapshot_data["expenses"][0]["amount"]

    # Change the live project data.
    project.name = "Modified Aluminum Project"

    project.items[0].unit_price = 120000

    project.expenses[0].amount = 250000

    db.commit()

    # Reload the snapshot from the database.
    db.expire_all()

    snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .first()
    )

    assert snapshot is not None

    data = snapshot.snapshot_data

    assert data["project"]["name"] == original_project_name
    assert data["items"][0]["unit_price"] == original_item_price
    assert data["expenses"][0]["amount"] == original_expense
    
    
def test_update_quotation_creates_new_snapshot_version(db):
    project = create_test_project(db)

    quotation_data = QuotationCreate(
        project_id=project.id,
        profit_percentage=25,
    )

    quotation = create_quotation(
        db,
        quotation_data,
    )

    first_snapshot = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .first()
    )

    assert first_snapshot is not None
    assert first_snapshot.version == 1

    original_selling_price = (
        first_snapshot.snapshot_data["quotation"]["selling_price"]
    )

    from app.schemas.quotation import QuotationUpdate
    from app.services.quotation_service import update_quotation

    updated_quotation = update_quotation(
        db,
        quotation.id,
        QuotationUpdate(
            profit_percentage=30,
        ),
    )

    assert updated_quotation is not None

    snapshots = (
        db.query(QuotationSnapshot)
        .filter(
            QuotationSnapshot.quotation_id == quotation.id
        )
        .order_by(
            QuotationSnapshot.version.asc()
        )
        .all()
    )

    assert len(snapshots) == 2

    version_one = snapshots[0]
    version_two = snapshots[1]

    assert version_one.version == 1
    assert version_two.version == 2

    assert (
        version_one.snapshot_data["quotation"]["selling_price"]
        == original_selling_price
    )

    assert (
        version_two.snapshot_data["quotation"]["profit_percentage"]
        == 30
    )

    assert (
        version_two.snapshot_data["quotation"]["selling_price"]
        != original_selling_price
    )