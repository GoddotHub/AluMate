using System;
using System.Collections.Generic;
using System.Text;

namespace AluMate.Models;

public class ProjectItemResponse
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string ItemType { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Quantity { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public string? Material { get; set; }

    public string? Profile { get; set; }

    public string? GlassType { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }
}
