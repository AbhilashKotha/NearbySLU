using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NearbySluWeb.Migrations.storeOffersAdd
{
    public partial class OfferDetailsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OffersDetails",
                columns: table => new
                {
                    offerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Offer_Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Offer_Description = table.Column<string>(type: "varchar(100)", nullable: false),
                    Offer_Category = table.Column<string>(type: "varchar(50)", nullable: false),
                    Offer_Valid_upto = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffersDetails", x => x.offerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffersDetails");
        }
    }
}
