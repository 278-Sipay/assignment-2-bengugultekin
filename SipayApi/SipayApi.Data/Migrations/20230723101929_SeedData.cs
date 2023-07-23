using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SipayApi.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Denny', 'Sellen', 100001, 'London', 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Ocean', 'OcConor', 100002, 'California', 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Michael', 'Black', 100003, 'St.Barbados', 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Poe', 'Smith', 100004, 'Detroit', 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Bella', 'Goth', 100005, 'New Jersey', 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customer]\r\n ([FirstName]\r\n ,[LastName]\r\n ,[CustomerNumber]\r\n ,[Address]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n ('Lauren', 'Bennett', 100006, 'Mexico', 1, GETDATE(), 'SystemAdmin')\r\n");

            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100001, 0 , 'Denny', '2023-02-05', 'USD', 500001, 1, GETDATE(), 'SystemAdmin')\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100002, 0 , 'Ocean', '2022-01-15', 'CAD', 500002, 1, GETDATE(), 'SystemAdmin' )\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100003, 0 , 'Michael', '2005-08-30', 'EUR', 500003, 1, GETDATE(), 'SystemAdmin' )\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100004, 0 , 'Poe', '2011-11-22', 'USD', 500004, 1, GETDATE(), 'SystemAdmin' )\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100005, 0 , 'Bella', '2012-07-10', 'EUR', 500005, 1, GETDATE(), 'SystemAdmin' )\r\n");
            migrationBuilder.Sql("INSERT INTO [dbo].[Account]\r\n ([CustomerNumber]\r\n ,[Balance]\r\n ,[Name]\r\n ,[OpenDate]\r\n ,[CurrencyCode]\r\n ,[AccountNumber]\r\n ,[IsActive]\r\n ,[InsertDate]\r\n ,[InsertUser])\r\n VALUES\r\n (100006, 0 , 'Lauren', '2020-04-11', 'TRY', 500006, 1, GETDATE(), 'SystemAdmin' )\r\n");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
