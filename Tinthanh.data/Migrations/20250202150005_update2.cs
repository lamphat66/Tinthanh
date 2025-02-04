using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinthanh.data.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhmucCTs_Danhmuc_DanhmucId",
                table: "DanhmucCTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhmucCTs",
                table: "DanhmucCTs");

            migrationBuilder.DropColumn(
                name: "Macu",
                table: "Kho");

            migrationBuilder.DropColumn(
                name: "STT",
                table: "DanhmucCTs");

            migrationBuilder.RenameTable(
                name: "DanhmucCTs",
                newName: "Danhmuc_CT");

            migrationBuilder.RenameIndex(
                name: "IX_DanhmucCTs_DanhmucId",
                table: "Danhmuc_CT",
                newName: "IX_Danhmuc_CT_DanhmucId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Danhmuc_CT",
                table: "Danhmuc_CT",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Danhmuc_CT_Danhmuc_DanhmucId",
                table: "Danhmuc_CT",
                column: "DanhmucId",
                principalTable: "Danhmuc",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Cascade);
           
            migrationBuilder.AddColumn<string>(
                name: "Macu",
                table: "Khachhang",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Danhmuc_CT_Danhmuc_DanhmucId",
                table: "Danhmuc_CT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Danhmuc_CT",
                table: "Danhmuc_CT");

            migrationBuilder.RenameTable(
                name: "Danhmuc_CT",
                newName: "DanhmucCTs");

            migrationBuilder.RenameIndex(
                name: "IX_Danhmuc_CT_DanhmucId",
                table: "DanhmucCTs",
                newName: "IX_DanhmucCTs_DanhmucId");

            migrationBuilder.AddColumn<string>(
                name: "Macu",
                table: "Kho",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STT",
                table: "DanhmucCTs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhmucCTs",
                table: "DanhmucCTs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DanhmucCTs_Danhmuc_DanhmucId",
                table: "DanhmucCTs",
                column: "DanhmucId",
                principalTable: "Danhmuc",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.DropColumn(
               name: "Macu",
               table: "Khachhang");

        }
    }
}
