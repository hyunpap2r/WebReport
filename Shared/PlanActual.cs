using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class PlanActual
{
    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public string? SalesFcstDivisionCode { get; set; }

    public string? SortType { get; set; }

    public long? InventoryItemId { get; set; }

    public DateOnly? ItemDate { get; set; }

    public long? ItemQty { get; set; }

    public long? CustSiteId { get; set; }

    public int Id { get; set; }
}
