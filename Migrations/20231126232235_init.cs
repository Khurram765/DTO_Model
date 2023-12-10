using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTOModel.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "breeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_breeds_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pet_breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "breeds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pet_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pet_locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_breeds_CategoryId",
                table: "breeds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_BreedId",
                table: "pet",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_CategoryId",
                table: "pet",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_LocationId",
                table: "pet",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "breeds");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
