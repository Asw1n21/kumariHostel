using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace kumariHostel.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45f601f7-cc27-41cb-a5f9-caa5cc053617", "2", "User", "User" },
                    { "65cbaf70-cc7f-45a9-b01c-2866d9a9db41", "3", "Staff", "Staff" },
                    { "6e004f91-10ec-440f-b761-2db909589f13", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45f601f7-cc27-41cb-a5f9-caa5cc053617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65cbaf70-cc7f-45a9-b01c-2866d9a9db41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e004f91-10ec-440f-b761-2db909589f13");
        }
    }
}
