using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class GroupAuth
{
    public string GroupName { get; set; } = null!;

    public string? Keterangan { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }
}
