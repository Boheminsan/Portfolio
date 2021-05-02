using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.WebUI.Migrations
{
    public partial class AddMenuOrderFixProductCategoryManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectCategories");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "MenuItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isParent",
                table: "MenuItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Footers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryProject",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProject", x => new { x.CategoriesCategoryId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_CategoryProject_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProject_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProject_ProjectsProjectId",
                table: "CategoryProject",
                column: "ProjectsProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProject");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "isParent",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Footers");

            migrationBuilder.CreateTable(
                name: "ProjectCategories",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCategories", x => new { x.ProjectId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProjectCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectCategories_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCategories_CategoryId",
                table: "ProjectCategories",
                column: "CategoryId");
        }
    }
}
