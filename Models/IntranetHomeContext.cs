using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ContactManagement.Models;

public partial class IntranetHomeContext : DbContext
{
    public IntranetHomeContext()
    {
    }

    public IntranetHomeContext(DbContextOptions<IntranetHomeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> ContactManagemen { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=IntranetHomeContext", Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.5.2-mariadb"));


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_uca1400_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Contact>(entity =>
        {
            entity
                .ToTable("contact_managemen")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasKey(e => e.Autoid);
            entity.Property(e => e.Alamat)
                .HasMaxLength(2500)
                .HasColumnName("alamat");
            entity.Property(e => e.AlamatLain)
                .HasMaxLength(2500)
                .HasColumnName("alamat_lain");
            entity.Property(e => e.Autoid)
                .HasMaxLength(25)
                .HasColumnName("autoid");
            entity.Property(e => e.Deskripsi)
                .HasMaxLength(2500)
                .HasColumnName("deskripsi");
            entity.Property(e => e.Email)
                .HasMaxLength(2500)
                .HasColumnName("email");
            entity.Property(e => e.Faxno)
                .HasMaxLength(2500)
                .HasDefaultValueSql("")
                .HasColumnName("faxno");
            entity.Property(e => e.Hpno)
                .HasMaxLength(2500)
                .HasColumnName("hpno");
            entity.Property(e => e.Kontak)
                .HasMaxLength(2500)
                .HasColumnName("kontak");
            entity.Property(e => e.MultiDeskripsi)
                .HasMaxLength(2500)
                .HasColumnName("multi_deskripsi");
            entity.Property(e => e.Nama).HasMaxLength(2500);
            entity.Property(e => e.Telpno)
                .HasMaxLength(2500)
                .HasColumnName("telpno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public string GenerateAutoid()
    {
        var maxAutoid = ContactManagemen
            .Where(c => !string.IsNullOrEmpty(c.Autoid))
            .Select(c => Convert.ToInt64(c.Autoid)) // Directly convert Autoid to integer
            .OrderByDescending(id => id)
            .FirstOrDefault();

        long newAutoid = maxAutoid + 1;

        return newAutoid.ToString();
    }
}
