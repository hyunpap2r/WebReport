using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared;

public partial class EappUser
{
    public int UserId { get; set; }
    
    public string? UserNo { get; set; }

    public long? UserGroup { get; set; }

    public string? UserGroupName { get; set; }

    public string? UserName { get; set; }
    public string Password { get; set; } = null!;

    public string? EnableFlag { get; set; }
}
