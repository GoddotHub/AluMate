using System;
using System.Collections.Generic;
using System.Text;

namespace AluMate.Models;

public class ProjectExpenseResponse
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string ExpenseType { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Amount { get; set; }
}

