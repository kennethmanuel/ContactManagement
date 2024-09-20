using System;
using System.Collections.Generic;

namespace ContactManagement.Models;

public partial class ContactManageman
{
    public string? Nama { get; set; }

    public string? Deskripsi { get; set; }

    public string? MultiDeskripsi { get; set; }

    public string? Alamat { get; set; }

    public string? AlamatLain { get; set; }

    public string? Kontak { get; set; }

    public string? Email { get; set; }

    public string? Faxno { get; set; }

    public string? Telpno { get; set; }

    public string? Hpno { get; set; }

    public int Autoid { get; set; }
}
