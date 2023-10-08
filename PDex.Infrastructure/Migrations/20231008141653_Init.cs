using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PDex.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name_English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_Japanese = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_Chinese = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_French = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stats_HP = table.Column<int>(type: "int", nullable: false),
                    Stats_Attack = table.Column<int>(type: "int", nullable: false),
                    Stats_Defense = table.Column<int>(type: "int", nullable: false),
                    Stats_SpAttack = table.Column<int>(type: "int", nullable: false),
                    Stats_SpDefense = table.Column<int>(type: "int", nullable: false),
                    Stats_Speed = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EncodedName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
