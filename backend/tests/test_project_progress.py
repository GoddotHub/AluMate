from fastapi.testclient import TestClient
from app.main import app
from app.database.database import get_db
from app.models.project import Project
from app.models.customer import Customer

client = TestClient(app)


def test_create_and_get_progress(db):
    # 1. Override the app's get_db dependency to use our test session
    app.dependency_overrides[get_db] = lambda: db

    try:
        # Setup prerequisite customer and project in test db
        customer = Customer(
            name="Test Customer", email="test@example.com", phone="123456789"
        )
        db.add(customer)
        db.commit()
        db.refresh(customer)

        project = Project(
            name="Alu Frame Project", customer_id=customer.id, status="Active"
        )
        db.add(project)
        db.commit()
        db.refresh(project)

        # Test POST progress milestone
        payload = {
            "milestone_name": "Cutting Aluminum Profiles",
            "status": "In Progress",
            "completion_percentage": 50,
            "notes": "Halfway done with frame pieces.",
        }

        response = client.post(f"/projects/{project.id}/progress", json=payload)
        assert response.status_code == 200
        data = response.json()
        assert data["milestone_name"] == "Cutting Aluminum Profiles"
        assert data["completion_percentage"] == 50
        assert data["project_id"] == project.id

        # Test GET progress list
        get_response = client.get(f"/projects/{project.id}/progress")
        assert get_response.status_code == 200
        progress_list = get_response.json()
        assert len(progress_list) == 1
        assert progress_list[0]["status"] == "In Progress"

    finally:
        # Clean up dependency override after test
        app.dependency_overrides.clear()
