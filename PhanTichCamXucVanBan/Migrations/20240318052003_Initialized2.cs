using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhanTichCamXucVanBan.Migrations
{
    /// <inheritdoc />
    public partial class Initialized2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhaHaiLong",
                table: "camXucs");

            migrationBuilder.DropColumn(
                name: "KhongHaiLong",
                table: "camXucs");

            migrationBuilder.DropColumn(
                name: "RatHaiLong",
                table: "camXucs");

            migrationBuilder.DropColumn(
                name: "RatKhongHaiLong",
                table: "camXucs");

            migrationBuilder.DropColumn(
                name: "ThatVong",
                table: "camXucs");

            migrationBuilder.AlterColumn<bool>(
                name: "HaiLong",
                table: "camXucs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "HaiLong",
                table: "camXucs",
                type: "float",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<double>(
                name: "KhaHaiLong",
                table: "camXucs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "KhongHaiLong",
                table: "camXucs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RatHaiLong",
                table: "camXucs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RatKhongHaiLong",
                table: "camXucs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ThatVong",
                table: "camXucs",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
