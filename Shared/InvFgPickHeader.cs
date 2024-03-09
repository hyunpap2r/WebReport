using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class InvFgPickHeader
{
    public long PickHeaderId { get; set; }

    public long? SobId { get; set; }

    public long? OrgId { get; set; }

    public DateOnly? PickDate { get; set; }

    public long? ShipToCustSiteId { get; set; }
}
