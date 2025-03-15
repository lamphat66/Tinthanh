using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class Update7th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopyFrom",
                table: "Phieuyeucau");

            migrationBuilder.DropColumn(
                name: "CopyTo",
                table: "Phieuyeucau");

            migrationBuilder.DropColumn(
                name: "CopyFrom",
                table: "Phieuxuly");

            migrationBuilder.DropColumn(
                name: "CopyTo",
                table: "Phieuxuly");

            migrationBuilder.DropColumn(
                name: "CopyFrom",
                table: "Phieuthukhuon");

            migrationBuilder.DropColumn(
                name: "CopyTo",
                table: "Phieuthukhuon");

            migrationBuilder.DropColumn(
                name: "CopyFrom",
                table: "Phieudinhgia");

            migrationBuilder.DropColumn(
                name: "CopyTo",
                table: "Phieudinhgia");

            migrationBuilder.DropColumn(
                name: "CopyFrom",
                table: "Phieubaogia");

            migrationBuilder.DropColumn(
                name: "CopyTo",
                table: "Phieubaogia");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngayhoanthanh",
                table: "Phieuyeucau",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Makh",
                table: "BanggiaKH",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngayhoanthanh",
                table: "Phieuyeucau");

            migrationBuilder.DropColumn(
                name: "Makh",
                table: "BanggiaKH");

            migrationBuilder.AddColumn<string>(
                name: "CopyFrom",
                table: "Phieuyeucau",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyTo",
                table: "Phieuyeucau",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyFrom",
                table: "Phieuxuly",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyTo",
                table: "Phieuxuly",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyFrom",
                table: "Phieuthukhuon",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyTo",
                table: "Phieuthukhuon",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyFrom",
                table: "Phieudinhgia",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyTo",
                table: "Phieudinhgia",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyFrom",
                table: "Phieubaogia",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CopyTo",
                table: "Phieubaogia",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
