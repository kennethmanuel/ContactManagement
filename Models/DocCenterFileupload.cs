using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class DocCenterFileupload
{
    public string? DokNumber { get; set; }

    public string? DokUpload { get; set; }

    public DateTime? Reuploadat { get; set; }
}
