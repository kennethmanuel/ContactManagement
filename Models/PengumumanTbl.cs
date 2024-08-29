using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class PengumumanTbl
{
    public string KodePengumuman { get; set; } = null!;

    public string? JudulPengumuman { get; set; }

    public string? JudulPendek { get; set; }

    public string? IsiPengumaman { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadAt { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Aktif { get; set; }

    public byte[]? AttchFilex { get; set; }

    public string? FileName { get; set; }

    public string? FileExt { get; set; }

    public byte[]? Filex { get; set; }
}
