using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Add_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "77320269-6614-4f27-ae37-0bb8cfd58ad224/04/24/18:48:10", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "cfd153b5-17a6-46c0-99a4-ba8020e83bca24/04/24/18:48:10", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "eed8fdb3-9851-4688-a023-84a3d619e17f24/04/24/18:48:10", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "5d7ef2c9-df31-4cd8-8560-9965c01e250b24/04/24/18:48:10", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "cfd153b5-17a6-46c0-99a4-ba8020e83bca24/04/24/18:48:10", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "65cd2496-d023-43a5-aa9d-664a45471bb824/04/24/18:48:10", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "77320269-6614-4f27-ae37-0bb8cfd58ad224/04/24/18:48:10", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "e1d5d117-9384-462b-b0c6-a5fd3387709724/04/24/18:48:10", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "eed8fdb3-9851-4688-a023-84a3d619e17f24/04/24/18:48:10", "123 Eve st", "Doe", "4000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "77320269-6614-4f27-ae37-0bb8cfd58ad224/04/24/18:48:10");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cfd153b5-17a6-46c0-99a4-ba8020e83bca24/04/24/18:48:10");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "eed8fdb3-9851-4688-a023-84a3d619e17f24/04/24/18:48:10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5d7ef2c9-df31-4cd8-8560-9965c01e250b24/04/24/18:48:10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65cd2496-d023-43a5-aa9d-664a45471bb824/04/24/18:48:10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e1d5d117-9384-462b-b0c6-a5fd3387709724/04/24/18:48:10");
        }
    }
}
