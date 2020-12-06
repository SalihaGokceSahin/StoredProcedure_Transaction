using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic_Crm.Migrations.Database
{
    public partial class spGetCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetCustomers
                                as
                                select * from Customers";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure spGetCustomers";
            migrationBuilder.Sql(procedure);
        }
    }
}
