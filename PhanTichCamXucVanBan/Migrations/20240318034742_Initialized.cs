using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhanTichCamXucVanBan.Migrations
{
    /// <inheritdoc />
    public partial class Initialized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "camXucs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhongGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThaiDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThucAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatHaiLong = table.Column<bool>(type: "bit", nullable: false),
                    KhaHaiLong = table.Column<bool>(type: "bit", nullable: false),
                    HaiLong = table.Column<bool>(type: "bit", nullable: false),
                    RatKhongHaiLong = table.Column<bool>(type: "bit", nullable: false),
                    KhongHaiLong = table.Column<bool>(type: "bit", nullable: false),
                    ThatVong = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_camXucs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "camXucs");
        }
    }
}
