using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic_Crm.Migrations.Database
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserSession",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserSession",
                table: "Customers");
        }
    }
}
