using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class InvItemMaster
{
    public long? InventoryItemId { get; set; }

    public long? SobId { get; set; }

    public long? OrgId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public long? CustomerSiteId { get; set; }

    public string? ItemSectionCode { get; set; }

    public string? ItemDivisionCode { get; set; }

    public string? ItemCategoryCode { get; set; }
}
