using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class InvFgPickLine
{
    public long? PickHeaderId { get; set; }

    public long? PickLineId { get; set; }

    public long? SobId { get; set; }

    public long? OrgId { get; set; }

    public long? InventoryItemId { get; set; }

    public long? PickQty { get; set; }
}
