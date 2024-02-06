using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeMgmt.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "company_id", "address", "company_name" },
                values: new object[,]
                {
                    { new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"), "Legos, Naigeria", "Info Model" },
                    { new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"), "Nairobi, Kenya", "Lead Tech" },
                    { new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"), "Addis Ababa, Ethiopia", "Hi Tech" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "employee_id", "CompanyId", "first_name", "last_name", "phone_number", "position" },
                values: new object[,]
                {
                    { new Guid("7d40cfc8-f801-4f84-80e1-a8605cbda9f5"), new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"), "Doe", "John", "2519-2334-23-34", "Software Enginner I" },
                    { new Guid("bfa08ba6-58ae-4ebc-b739-c61c585dd2ec"), new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"), "Smith", "Kyle", "2519-4334-23-44", "Software Enginner II" },
                    { new Guid("d8aa10d8-32b1-46eb-8446-0caa6634c6fa"), new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"), "Helen", "Million", "+1029-2334-23-34", "Software Enginner III" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employee_id",
                keyValue: new Guid("7d40cfc8-f801-4f84-80e1-a8605cbda9f5"));

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employee_id",
                keyValue: new Guid("bfa08ba6-58ae-4ebc-b739-c61c585dd2ec"));

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employee_id",
                keyValue: new Guid("d8aa10d8-32b1-46eb-8446-0caa6634c6fa"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "company_id",
                keyValue: new Guid("67e91a90-56e4-4339-9fbe-c370d16db1d5"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "company_id",
                keyValue: new Guid("c56d2e35-cbbc-4c11-9382-c19a77d0f025"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "company_id",
                keyValue: new Guid("f1bd225f-a114-473b-b9ae-13de83feac57"));
        }
    }
}
