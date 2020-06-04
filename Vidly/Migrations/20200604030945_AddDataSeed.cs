using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipType",
                columns: new[] { "Id", "DiscountRate", "DurationInMonths", "SignUpFee" },
                values: new object[,]
                {
                    { 1, (byte)0, (byte)0, (short)0 },
                    { 2, (byte)10, (byte)1, (short)30 },
                    { 3, (byte)15, (byte)3, (short)90 },
                    { 4, (byte)30, (byte)12, (short)300 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "The Seven Samurai" },
                    { 2, "Bonnie and Clyde" },
                    { 3, "Reservoir Dogs" },
                    { 4, "Airplane!" },
                    { 5, "Pan's Labyrinth" },
                    { 6, "Doctor Zhivago" },
                    { 7, "Pulp Fiction" },
                    { 8, "The Shawshank Redemption" },
                    { 9, "Citizen Kane" },
                    { 10, "The Wizard of Oz" },
                    { 11, "The Godfather" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IsSubscribedToNewsletter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, true, 1, "Jaspal" },
                    { 4, false, 2, "Harkawal" },
                    { 3, true, 3, "Vikram" },
                    { 2, false, 4, "Harpreet" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
