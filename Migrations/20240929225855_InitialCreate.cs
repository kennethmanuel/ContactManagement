using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contact_managemen",
                columns: table => new
                {
                    pkid = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    deskripsi = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    multi_deskripsi = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    alamat = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    alamat_lain = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    kontak = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    email = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    faxno = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, defaultValueSql: "''''", collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    telpno = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    hpno = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    autoid = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.pkid);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact_managemen");
        }
    }
}
