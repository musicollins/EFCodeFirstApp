using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirstApp.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "Milanes", 333422, "Rafael" },
                    { 2, "Cage", 775647, "Johnny" },
                    { 3, "Lindgren", 9873, "Anna" },
                    { 4, "Pérez", 112342, "Juanete" },
                    { 5, "SuperNew", 7746398, "New" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
