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

    public virtual DbSet<BeritadukaTbl> BeritadukaTbls { get; set; }

    public virtual DbSet<CompanyVideo> CompanyVideos { get; set; }

    public virtual DbSet<ContactManageman> ContactManagemen { get; set; }

    public virtual DbSet<DocCenterFileupload> DocCenterFileuploads { get; set; }

    public virtual DbSet<DocCenterGroupAuth> DocCenterGroupAuths { get; set; }

    public virtual DbSet<DocCenterUserAuth> DocCenterUserAuths { get; set; }

    public virtual DbSet<DocumentCenterIso> DocumentCenterIsos { get; set; }

    public virtual DbSet<DokCenterGroupFile> DokCenterGroupFiles { get; set; }

    public virtual DbSet<ExtDirTambahan> ExtDirTambahans { get; set; }

    public virtual DbSet<ExtNumberTbl> ExtNumberTbls { get; set; }

    public virtual DbSet<ExtNumberTblCopy> ExtNumberTblCopies { get; set; }

    public virtual DbSet<GroupAuth> GroupAuths { get; set; }

    public virtual DbSet<GroupAuthDetail> GroupAuthDetails { get; set; }

    public virtual DbSet<GroupAuthEmp> GroupAuthEmps { get; set; }

    public virtual DbSet<ItWebQuicklink> ItWebQuicklinks { get; set; }

    public virtual DbSet<ItWebSupport> ItWebSupports { get; set; }

    public virtual DbSet<PengumumanTbl> PengumumanTbls { get; set; }

    public virtual DbSet<SpeeddialTbl> SpeeddialTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.106.225;port=3306;database=intranet_home;user id=root;password=myroot", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.14-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<BeritadukaTbl>(entity =>
        {
            entity.HasKey(e => e.KodePengumuman).HasName("PRIMARY");

            entity.ToTable("beritaduka_tbl");

            entity.HasIndex(e => e.JudulPengumuman, "indx1").IsUnique();

            entity.HasIndex(e => e.JudulPendek, "indx2").IsUnique();

            entity.Property(e => e.KodePengumuman)
                .HasMaxLength(50)
                .HasColumnName("kode_pengumuman");
            entity.Property(e => e.Aktif)
                .HasMaxLength(2)
                .HasColumnName("aktif");
            entity.Property(e => e.AttchFile)
                .HasColumnType("blob")
                .HasColumnName("attch_file");
            entity.Property(e => e.ExpiredDate)
                .HasColumnType("datetime")
                .HasColumnName("expired_date");
            entity.Property(e => e.FileExt)
                .HasMaxLength(300)
                .HasColumnName("file_ext");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .HasColumnName("file_name");
            entity.Property(e => e.Filex).HasColumnName("filex");
            entity.Property(e => e.IsiPengumaman).HasColumnName("isi_pengumaman");
            entity.Property(e => e.JudulPendek)
                .HasMaxLength(30)
                .HasColumnName("judul_pendek");
            entity.Property(e => e.JudulPengumuman)
                .HasMaxLength(350)
                .HasColumnName("judul_pengumuman");
            entity.Property(e => e.UploadAt)
                .HasColumnType("datetime")
                .HasColumnName("upload_at");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(350)
                .HasColumnName("upload_by");
        });

        modelBuilder.Entity<CompanyVideo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("company_video");

            entity.Property(e => e.Alamatip)
                .HasMaxLength(50)
                .HasColumnName("alamatip");
            entity.Property(e => e.Browsername)
                .HasMaxLength(1500)
                .HasColumnName("browsername");
            entity.Property(e => e.Browserplatform)
                .HasMaxLength(150)
                .HasColumnName("browserplatform");
            entity.Property(e => e.FlagInout)
                .HasMaxLength(150)
                .HasColumnName("flag_inout");
            entity.Property(e => e.Menuvideo)
                .HasMaxLength(500)
                .HasColumnName("menuvideo");
            entity.Property(e => e.Tgllogin)
                .HasColumnType("datetime")
                .HasColumnName("tgllogin");
            entity.Property(e => e.Userlogin)
                .HasMaxLength(500)
                .HasColumnName("userlogin");
        });

        modelBuilder.Entity<ContactManageman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contact_managemen");

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
                .HasDefaultValueSql("''")
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

        modelBuilder.Entity<DocCenterFileupload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("doc_center_fileupload");

            entity.Property(e => e.DokNumber)
                .HasMaxLength(500)
                .HasColumnName("dok_number");
            entity.Property(e => e.DokUpload)
                .HasMaxLength(500)
                .HasColumnName("dok_upload");
            entity.Property(e => e.Reuploadat)
                .HasColumnType("datetime")
                .HasColumnName("reuploadat");
        });

        modelBuilder.Entity<DocCenterGroupAuth>(entity =>
        {
            entity.HasKey(e => new { e.DocumentNo, e.GroupName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("doc_center_group_auth");

            entity.Property(e => e.DocumentNo)
                .HasMaxLength(300)
                .HasColumnName("document_no");
            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .HasColumnName("group_name");
        });

        modelBuilder.Entity<DocCenterUserAuth>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.SamaccName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("doc_center_user_auth");

            entity.Property(e => e.DocNo)
                .HasMaxLength(300)
                .HasColumnName("doc_no");
            entity.Property(e => e.SamaccName)
                .HasMaxLength(2500)
                .HasColumnName("samacc_name");
        });

        modelBuilder.Entity<DocumentCenterIso>(entity =>
        {
            entity.HasKey(e => e.DocumentNo).HasName("PRIMARY");

            entity.ToTable("document_center_iso");

            entity.HasIndex(e => e.DocumentName, "Index 2").IsUnique();

            entity.Property(e => e.DocumentNo)
                .HasMaxLength(300)
                .HasColumnName("document_no");
            entity.Property(e => e.Aktif)
                .HasMaxLength(1)
                .HasColumnName("aktif");
            entity.Property(e => e.DocType)
                .HasMaxLength(20)
                .HasColumnName("Doc_type");
            entity.Property(e => e.DocumentBlob).HasColumnName("document_blob");
            entity.Property(e => e.DocumentExt)
                .HasMaxLength(500)
                .HasColumnName("document_ext");
            entity.Property(e => e.DocumentFilename)
                .HasMaxLength(1500)
                .HasColumnName("document_filename");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(2000)
                .HasColumnName("document_name");
            entity.Property(e => e.NonAktifBy)
                .HasMaxLength(1500)
                .HasColumnName("non_aktif_by");
            entity.Property(e => e.NonAktifat)
                .HasColumnType("datetime")
                .HasColumnName("non_aktifat");
            entity.Property(e => e.UploadAt)
                .HasColumnType("datetime")
                .HasColumnName("upload_at");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(1500)
                .HasColumnName("upload_by");
        });

        modelBuilder.Entity<DokCenterGroupFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dok_center_group_file");

            entity.Property(e => e.DokName)
                .HasMaxLength(250)
                .HasColumnName("dok_name");
            entity.Property(e => e.Seksi)
                .HasMaxLength(250)
                .HasColumnName("seksi");
        });

        modelBuilder.Entity<ExtDirTambahan>(entity =>
        {
            entity.HasKey(e => new { e.Groupx, e.Nomor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("ext_dir_tambahan");

            entity.Property(e => e.Groupx).HasMaxLength(50);
            entity.Property(e => e.Nomor).HasMaxLength(30);
            entity.Property(e => e.Keterangan).HasMaxLength(150);
        });

        modelBuilder.Entity<ExtNumberTbl>(entity =>
        {
            entity.HasKey(e => new { e.Nama, e.Area, e.ExtNum })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("ext_number_tbl");

            entity.Property(e => e.Nama)
                .HasMaxLength(350)
                .HasColumnName("nama");
            entity.Property(e => e.Area)
                .HasMaxLength(350)
                .HasColumnName("area");
            entity.Property(e => e.ExtNum)
                .HasMaxLength(25)
                .HasColumnName("ext_num");
        });

        modelBuilder.Entity<ExtNumberTblCopy>(entity =>
        {
            entity.HasKey(e => new { e.Nama, e.Area, e.ExtNum })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("ext_number_tbl_copy");

            entity.Property(e => e.Nama)
                .HasMaxLength(350)
                .HasColumnName("nama");
            entity.Property(e => e.Area)
                .HasMaxLength(350)
                .HasColumnName("area");
            entity.Property(e => e.ExtNum)
                .HasMaxLength(25)
                .HasColumnName("ext_num");
        });

        modelBuilder.Entity<GroupAuth>(entity =>
        {
            entity.HasKey(e => e.GroupName).HasName("PRIMARY");

            entity.ToTable("group_auth");

            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .HasColumnName("Group_name");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("Create_at");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(1500)
                .HasColumnName("Create_by");
            entity.Property(e => e.Keterangan).HasMaxLength(500);
        });

        modelBuilder.Entity<GroupAuthDetail>(entity =>
        {
            entity.HasKey(e => new { e.GroupName, e.SamaccName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("group_auth_detail");

            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .HasColumnName("Group_name");
            entity.Property(e => e.SamaccName)
                .HasMaxLength(1500)
                .HasColumnName("samacc_name");
        });

        modelBuilder.Entity<GroupAuthEmp>(entity =>
        {
            entity.HasKey(e => new { e.GroupName, e.Samaccname })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("group_auth_emp");

            entity.Property(e => e.GroupName)
                .HasMaxLength(250)
                .HasColumnName("group_name");
            entity.Property(e => e.Samaccname)
                .HasMaxLength(250)
                .HasColumnName("samaccname");
        });

        modelBuilder.Entity<ItWebQuicklink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("it_web_quicklink");

            entity.Property(e => e.Groups).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Urlx)
                .HasMaxLength(800)
                .HasColumnName("urlx");
        });

        modelBuilder.Entity<ItWebSupport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("it_web_support");

            entity.Property(e => e.Groups).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Urlx)
                .HasMaxLength(800)
                .HasColumnName("urlx");
        });

        modelBuilder.Entity<PengumumanTbl>(entity =>
        {
            entity.HasKey(e => e.KodePengumuman).HasName("PRIMARY");

            entity.ToTable("pengumuman_tbl");

            entity.HasIndex(e => e.JudulPengumuman, "uniq1").IsUnique();

            entity.HasIndex(e => e.JudulPendek, "uniq2").IsUnique();

            entity.Property(e => e.KodePengumuman)
                .HasMaxLength(50)
                .HasColumnName("kode_pengumuman");
            entity.Property(e => e.Aktif)
                .HasMaxLength(2)
                .HasColumnName("aktif");
            entity.Property(e => e.AttchFilex)
                .HasColumnType("blob")
                .HasColumnName("attch_filex");
            entity.Property(e => e.ExpiredDate)
                .HasColumnType("datetime")
                .HasColumnName("expired_date");
            entity.Property(e => e.FileExt)
                .HasMaxLength(300)
                .HasColumnName("file_ext");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .HasColumnName("file_name");
            entity.Property(e => e.Filex).HasColumnName("filex");
            entity.Property(e => e.IsiPengumaman).HasColumnName("isi_pengumaman");
            entity.Property(e => e.JudulPendek)
                .HasMaxLength(30)
                .HasColumnName("judul_pendek");
            entity.Property(e => e.JudulPengumuman)
                .HasMaxLength(350)
                .HasColumnName("judul_pengumuman");
            entity.Property(e => e.UploadAt)
                .HasColumnType("datetime")
                .HasColumnName("upload_at");
            entity.Property(e => e.UploadBy)
                .HasMaxLength(350)
                .HasColumnName("upload_by");
        });

        modelBuilder.Entity<SpeeddialTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("speeddial_tbl");

            entity.Property(e => e.Bagian)
                .HasMaxLength(1500)
                .HasColumnName("bagian");
            entity.Property(e => e.Nama)
                .HasMaxLength(1500)
                .HasColumnName("nama");
            entity.Property(e => e.Notelp)
                .HasMaxLength(150)
                .HasColumnName("notelp");
            entity.Property(e => e.Speedno)
                .HasMaxLength(15)
                .HasColumnName("speedno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
