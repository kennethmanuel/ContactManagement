using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class DocumentCenterIso
{
    public string DocumentNo { get; set; } = null!;

    public string? DocumentName { get; set; }

    public byte[]? DocumentBlob { get; set; }

    public string? DocumentFilename { get; set; }

    public string? DocumentExt { get; set; }

    public string? Aktif { get; set; }

    public DateTime? UploadAt { get; set; }

    public string? UploadBy { get; set; }

    public string? NonAktifBy { get; set; }

    public DateTime? NonAktifat { get; set; }

    public string? DocType { get; set; }
}
