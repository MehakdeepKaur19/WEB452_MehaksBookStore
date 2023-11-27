using Microsoft.EntityFrameworkCore.Migrations;

namespace MehaksBooks.DataAccess.Migrations
{
    public partial class addProductToDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ListPrice",
                table: "Products",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "ListPrice");
        }
    }
}
