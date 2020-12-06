using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic_Crm.Migrations.Database
{
    public partial class spGetCustomerById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetCustomerById @Id int as Begin select * from Customers where Id=@Id end";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure spGetCustomerById";
            migrationBuilder.Sql(procedure);
        }
    }
}
