using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared;

public partial class EappLookupEntry
{
    public int? LookupTypeId { get; set; }

    public string? EntryCode { get; set; }

    public string? EntryDescription { get; set; }

    public int? SortNo { get; set; }

    public int Id { get; set; }
}
