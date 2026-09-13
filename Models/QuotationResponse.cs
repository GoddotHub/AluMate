using System;
using System.Collections.Generic;
using System.Text;

namespace AluMate.Models;

public class QuotationResponse
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string QuotationNumber { get; set; } = string.Empty;

    public decimal CurrentCost { get; set; }

    public decimal ProfitPercentage { get; set; }

    public decimal ProfitAmount { get; set; }

    public decimal SellingPrice { get; set; }

    public string Status { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }
}
