using System;

namespace AluMate.Models;

public class ProjectSummaryResponse
{
    public int ItemCount { get; set; }

    public int ExpenseCount { get; set; }

    public decimal TotalCost { get; set; }
}