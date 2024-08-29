using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class BeritadukaTbl
{
    public string KodePengumuman { get; set; } = null!;

    public string? JudulPengumuman { get; set; }

    public string? JudulPendek { get; set; }

    public string? IsiPengumaman { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadAt { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Aktif { get; set; }

    public byte[]? AttchFile { get; set; }

    public string? FileName { get; set; }

    public string? FileExt { get; set; }

    public byte[]? Filex { get; set; }
}
