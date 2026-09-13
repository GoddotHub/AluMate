from fastapi import FastAPI

from app.routers.customers import router as customers_router
from app.routers.projects import router as projects_router
from app.routers.project_items import router as project_items_router
from app.routers.project_expenses import router as project_expenses_router
from app.routers.quotations import router as quotations_router
from app.routers.project_progress import router as project_progress_router  # Added

app = FastAPI(
    title="AluMate API",
    description="Backend API for the AluMate aluminum fabrication application.",
    version="1.0.0",
)

app.include_router(customers_router)
app.include_router(projects_router)
app.include_router(project_items_router)
app.include_router(project_expenses_router)
app.include_router(quotations_router)
app.include_router(project_progress_router)  # Registered


@app.get("/")
def home():
    return {
        "application": "AluMate",
        "message": "AluMate API is running!",
        "version": "1.0.0",
    }


from app.routers import dashboard

app.include_router(dashboard.router)
