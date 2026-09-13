using System;
using System.Collections.Generic;
using System.Text;

namespace AluMate.Models;

public class ProjectResponse
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string Status { get; set; } = string.Empty;

    public decimal? QuotedPrice { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
