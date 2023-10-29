using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Captain Jack Sparrow (Johnny Depp) sets sail for a fifth effects-filled swashbuckler, now on a quest for the Trident of Poseidon and the ultimate power it can bestow. However, he'll have to outrace young Henry Turner (Brenton Thwaites), who's looking to free father Will (Orlando Bloom) from the Flying Dutchman's curse... and outpace the vengeance hunt of the undead Captain Salazar (Javier Bardem). Geoffrey Rush, Kaya Scodelario, and Keira Knightley co-star.", "https://m.media-amazon.com/images/I/81aLSDXBZqL._AC_SY606_.jpg", 39.99m, "Pirates of the Caribbean: Dead Men Tell No Tales (DVD/Blu-ray)" },
                    { 2, "This is a must have for every Might and Magic series fan! Includes Heroes of Might & Magic III and its expansions: Armageddon's Blade and The Shadow of Death. Insanely addictive gameplay that will make you want to play “just one more turn” over and over again great multiplayer, especially when playing in hot seat mode on one PC", "https://i.ebayimg.com/images/g/0pcAAOSw3~diWWLL/s-l1600.jpg", 35m, "Heroes of Might & Magic III Complete (PC CD-ROM)" },
                    { 3, "This is the original vintage gaming system from the 1980's. It comes with brand new accessories, which makes you feel like you are playing it for the first time again! Please note that this is NOT the \"Classic\" edition that has pre-loaded games, you will have to use old school game cartridges in this system (not included) like its 1989.", "https://i.ebayimg.com/images/g/AD4AAOSw3YphYRwA/s-l1600.jpg", 170m, "ORIGINAL Nintendo Entertainment System Video Game Bundle Set Kit NES Console OG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
