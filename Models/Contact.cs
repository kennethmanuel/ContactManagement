using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.Models;

public partial class Contact
{
    [Key]
    public string? Autoid { get; set; }

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

    public static Contact CreateNewContact()
    {
        return new Contact
        {
            Autoid = Guid.NewGuid().ToString() // Generate a new Autoid for new contacts
        };
    }
}
