using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_entity.Migrations
{
    /// <inheritdoc />
    public partial class AddSlider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliderlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Resim = table.Column<string>(type: "TEXT", nullable: true),
                    Baslik = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Aktif = table.Column<bool>(type: "INTEGER", nullable: false),
                    Index = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliderlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sliderlar",
                columns: new[] { "Id", "Aciklama", "Aktif", "Baslik", "Index", "Resim" },
                values: new object[,]
                {
                    { 1, "İndirimli Ürünler", true, "İndirimli Ürünler", 0, "slider-1.jpeg" },
                    { 2, "Yeni Gelen Ürünler", true, "Yeni Gelen Ürünler", 1, "slider-2.jpeg" },
                    { 3, "Popüler Ürünler", true, "Popüler Ürünler", 2, "slider-3.jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliderlar");
        }
    }
}
