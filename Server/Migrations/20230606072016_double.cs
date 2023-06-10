using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zasham.Server.Migrations
{
    /// <inheritdoc />
    public partial class @double : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Customer_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Customer_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
