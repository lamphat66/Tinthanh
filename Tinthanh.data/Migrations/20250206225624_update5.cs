using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "KhuonId",
                table: "Khuon_CT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Tentat",
            //    table: "Khomay",
            //    type: "nvarchar(50)",
            //    maxLength: 50,
            //    nullable: true);

            migrationBuilder.CreateTable(
                name: "Khachhang_Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KhachhangId = table.Column<int>(type: "int", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachhang_Tailieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Khachhang_Tailieu_Khachhang_KhachhangId",
                        column: x => x.KhachhangId,
                        principalTable: "Khachhang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khuon_Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KhuonId = table.Column<int>(type: "int", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khuon_Tailieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Khuon_Tailieu_Khuon_KhuonId",
                        column: x => x.KhuonId,
                        principalTable: "Khuon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhaCC_Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NhacungcapId = table.Column<int>(type: "int", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCC_Tailieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhaCC_Tailieu_Nhacungcap_NhacungcapId",
                        column: x => x.NhacungcapId,
                        principalTable: "Nhacungcap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thanhpham_Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhphamId = table.Column<int>(type: "int", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanhpham_Tailieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thanhpham_Tailieu_Thanhpham_ThanhphamId",
                        column: x => x.ThanhphamId,
                        principalTable: "Thanhpham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vattu_Tailieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenfile = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VattuId = table.Column<int>(type: "int", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phanloai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ngungsd = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vattu_Tailieu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vattu_Tailieu_Vattu_VattuId",
                        column: x => x.VattuId,
                        principalTable: "Vattu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Khachhang_Tailieu_KhachhangId",
                table: "Khachhang_Tailieu",
                column: "KhachhangId");

            migrationBuilder.CreateIndex(
                name: "IX_Khuon_Tailieu_KhuonId",
                table: "Khuon_Tailieu",
                column: "KhuonId");

            migrationBuilder.CreateIndex(
                name: "IX_NhaCC_Tailieu_NhacungcapId",
                table: "NhaCC_Tailieu",
                column: "NhacungcapId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanhpham_Tailieu_ThanhphamId",
                table: "Thanhpham_Tailieu",
                column: "ThanhphamId");

            migrationBuilder.CreateIndex(
                name: "IX_Vattu_Tailieu_VattuId",
                table: "Vattu_Tailieu",
                column: "VattuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khachhang_Tailieu");

            migrationBuilder.DropTable(
                name: "Khuon_Tailieu");

            migrationBuilder.DropTable(
                name: "NhaCC_Tailieu");

            migrationBuilder.DropTable(
                name: "Thanhpham_Tailieu");

            migrationBuilder.DropTable(
                name: "Vattu_Tailieu");

            //migrationBuilder.DropColumn(
            //    name: "Tentat",
            //    table: "Khomay");

            migrationBuilder.AlterColumn<int>(
                name: "KhuonId",
                table: "Khuon_CT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
