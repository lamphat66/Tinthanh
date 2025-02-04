using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KhuonBG",
                table: "KhuonBG");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "LienlacNCC");

            migrationBuilder.AlterColumn<string>(
                name: "TKphi",
                table: "Thanhpham",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TKkho",
                table: "Thanhpham",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manhom",
                table: "Thanhpham",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mabo",
                table: "Thanhpham",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ghichu",
                table: "Thanhpham",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Donvi",
                table: "Thanhpham",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KhuonBG",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SanphamId",
                table: "Khuon_CT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhachhangId",
                table: "Khuon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Thuoc",
                table: "Khachhang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Makv",
                table: "Khachhang",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ghichu",
                table: "Khachhang",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ngungsd",
                table: "Donvisanpham",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Ma",
                table: "Danhmuc_CT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NhaCCId",
                table: "BanggiaNCC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VattuId",
                table: "BanggiaNCC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KhachhangId",
                table: "BanggiaKH",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SanphamId",
                table: "BanggiaKH",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhuonBG",
                table: "KhuonBG",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_KhuonBG_Ma",
                table: "KhuonBG",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaNCC_NhaCCId_VattuId",
                table: "BanggiaNCC",
                columns: new[] { "NhaCCId", "VattuId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaKH_KhachhangId_SanphamId",
                table: "BanggiaKH",
                columns: new[] { "KhachhangId", "SanphamId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KhuonBG",
                table: "KhuonBG");

            migrationBuilder.DropIndex(
                name: "IX_KhuonBG_Ma",
                table: "KhuonBG");

            migrationBuilder.DropIndex(
                name: "IX_BanggiaNCC_NhaCCId_VattuId",
                table: "BanggiaNCC");

            migrationBuilder.DropIndex(
                name: "IX_BanggiaKH_KhachhangId_SanphamId",
                table: "BanggiaKH");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KhuonBG");

            migrationBuilder.DropColumn(
                name: "SanphamId",
                table: "Khuon_CT");

            migrationBuilder.DropColumn(
                name: "KhachhangId",
                table: "Khuon");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "Danhmuc_CT");

            migrationBuilder.DropColumn(
                name: "NhaCCId",
                table: "BanggiaNCC");

            migrationBuilder.DropColumn(
                name: "VattuId",
                table: "BanggiaNCC");

            migrationBuilder.DropColumn(
                name: "KhachhangId",
                table: "BanggiaKH");

            migrationBuilder.DropColumn(
                name: "SanphamId",
                table: "BanggiaKH");

            migrationBuilder.AlterColumn<string>(
                name: "TKphi",
                table: "Thanhpham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TKkho",
                table: "Thanhpham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manhom",
                table: "Thanhpham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mabo",
                table: "Thanhpham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ghichu",
                table: "Thanhpham",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Donvi",
                table: "Thanhpham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "LienlacNCC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Thuoc",
                table: "Khachhang",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Makv",
                table: "Khachhang",
                type: "int",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ghichu",
                table: "Khachhang",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ngungsd",
                table: "Donvisanpham",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhuonBG",
                table: "KhuonBG",
                column: "Ma");
        }
    }
}
