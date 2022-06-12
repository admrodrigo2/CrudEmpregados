using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcApplication1.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(250)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(250)", nullable: true),
                    Cargo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empregados");
        }
    }
}
