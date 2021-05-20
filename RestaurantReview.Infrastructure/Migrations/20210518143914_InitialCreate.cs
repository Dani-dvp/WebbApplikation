using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RestaurantCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleMapsPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRestaurant",
                columns: table => new
                {
                    CategoriesCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantsRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRestaurant", x => new { x.CategoriesCategoryID, x.RestaurantsRestaurantID });
                    table.ForeignKey(
                        name: "FK_CategoryRestaurant_Category_CategoriesCategoryID",
                        column: x => x.CategoriesCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryRestaurant_Restaurants_RestaurantsRestaurantID",
                        column: x => x.RestaurantsRestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageRestaurant",
                columns: table => new
                {
                    ImagesImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantsRestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageRestaurant", x => new { x.ImagesImageID, x.RestaurantsRestaurantID });
                    table.ForeignKey(
                        name: "FK_ImageRestaurant_Images_ImagesImageID",
                        column: x => x.ImagesImageID,
                        principalTable: "Images",
                        principalColumn: "ImageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageRestaurant_Restaurants_RestaurantsRestaurantID",
                        column: x => x.RestaurantsRestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    RestaurantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRestaurant_RestaurantsRestaurantID",
                table: "CategoryRestaurant",
                column: "RestaurantsRestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_ImageRestaurant_RestaurantsRestaurantID",
                table: "ImageRestaurant",
                column: "RestaurantsRestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantID",
                table: "Reviews",
                column: "RestaurantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryRestaurant");

            migrationBuilder.DropTable(
                name: "ImageRestaurant");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
