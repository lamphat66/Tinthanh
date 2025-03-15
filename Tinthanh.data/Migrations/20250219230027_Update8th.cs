using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class Update8th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chungtu",
                columns: table => new
                {
                    Maphieu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Loaiphieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chungtu", x => x.Maphieu);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    CopyFrom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CopyTo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => new { x.CopyFrom, x.CopyTo });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chungtu");

            migrationBuilder.DropTable(
                name: "Link");
        }
    }
}
