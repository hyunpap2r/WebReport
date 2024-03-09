using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class InvPickRequest
{
    public DateTime? ExtendDate { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public string? OrderNo { get; set; }

    public long? CustSiteCode { get; set; }

    public string? OrderTypeDesc { get; set; }

    public long? SalesOrderQty { get; set; }

    public long? DeliveryQty { get; set; }

    public long? InventoryItemId { get; set; }

    public string? PickFlag { get; set; }
}
