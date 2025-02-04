using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonviVattu_Vattu_VattuId",
                table: "DonviVattu");

            migrationBuilder.DropForeignKey(
                name: "FK_LienlacKH_Khachhang_KhachhangId",
                table: "LienlacKH");

            migrationBuilder.DropIndex(
                name: "IX_BanggiaNCC_MaVT_MaDT",
                table: "BanggiaNCC");

            migrationBuilder.DropIndex(
                name: "IX_BanggiaKH_Masp_Makh",
                table: "BanggiaKH");

            migrationBuilder.DropColumn(
                name: "MaDT",
                table: "BanggiaNCC");

            migrationBuilder.DropColumn(
                name: "MaVT",
                table: "BanggiaNCC");

            migrationBuilder.DropColumn(
                name: "Makh",
                table: "BanggiaKH");

            migrationBuilder.RenameColumn(
                name: "NgayUpdate",
                table: "BanggiaNCC",
                newName: "Ngaygiagoc");

            migrationBuilder.AlterColumn<string>(
                name: "Kho",
                table: "Vattu",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "Cohinh",
                table: "Vattu",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhachhangId",
                table: "LienlacKH",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hoten",
                table: "LienlacKH",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diachi",
                table: "LienlacKH",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VattuId",
                table: "DonviVattu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Donvi",
                table: "DonviVattu",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaycapnhat",
                table: "BanggiaNCC",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Masp",
                table: "BanggiaKH",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_DonviVattu_Vattu_VattuId",
                table: "DonviVattu",
                column: "VattuId",
                principalTable: "Vattu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LienlacKH_Khachhang_KhachhangId",
                table: "LienlacKH",
                column: "KhachhangId",
                principalTable: "Khachhang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonviVattu_Vattu_VattuId",
                table: "DonviVattu");

            migrationBuilder.DropForeignKey(
                name: "FK_LienlacKH_Khachhang_KhachhangId",
                table: "LienlacKH");

            migrationBuilder.DropColumn(
                name: "Cohinh",
                table: "Vattu");

            migrationBuilder.DropColumn(
                name: "Ngaycapnhat",
                table: "BanggiaNCC");

            migrationBuilder.RenameColumn(
                name: "Ngaygiagoc",
                table: "BanggiaNCC",
                newName: "NgayUpdate");

            migrationBuilder.AlterColumn<string>(
                name: "Kho",
                table: "Vattu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhachhangId",
                table: "LienlacKH",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Hoten",
                table: "LienlacKH",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Diachi",
                table: "LienlacKH",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VattuId",
                table: "DonviVattu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Donvi",
                table: "DonviVattu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "MaDT",
                table: "BanggiaNCC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaVT",
                table: "BanggiaNCC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Masp",
                table: "BanggiaKH",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Makh",
                table: "BanggiaKH",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaNCC_MaVT_MaDT",
                table: "BanggiaNCC",
                columns: new[] { "MaVT", "MaDT" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BanggiaKH_Masp_Makh",
                table: "BanggiaKH",
                columns: new[] { "Masp", "Makh" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DonviVattu_Vattu_VattuId",
                table: "DonviVattu",
                column: "VattuId",
                principalTable: "Vattu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LienlacKH_Khachhang_KhachhangId",
                table: "LienlacKH",
                column: "KhachhangId",
                principalTable: "Khachhang",
                principalColumn: "Id");
        }
    }
}
