using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EventCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    EventCategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "01a54960-26f7-45ae-a28e-fdac3541e1f524/04/25/16:54:25", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "1d111f0f-29cb-4ffd-bbf3-8b90644a290124/04/25/16:54:25", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "856715fe-f516-4fbd-974b-831d31923f5024/04/25/16:54:25", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "27e31126-0fee-4068-9074-d79bc80fd30a24/04/25/16:54:25", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "856715fe-f516-4fbd-974b-831d31923f5024/04/25/16:54:25", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "ddd1490a-7033-4ab3-8660-b62ae660ca8524/04/25/16:54:25", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "1d111f0f-29cb-4ffd-bbf3-8b90644a290124/04/25/16:54:25", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "e821e7a2-7bfb-4eba-a1f2-70b02b39412e24/04/25/16:54:25", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "01a54960-26f7-45ae-a28e-fdac3541e1f524/04/25/16:54:25", "123 Eve st", "Mchunu", "4000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventCategories");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "01a54960-26f7-45ae-a28e-fdac3541e1f524/04/25/16:54:25");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1d111f0f-29cb-4ffd-bbf3-8b90644a290124/04/25/16:54:25");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "856715fe-f516-4fbd-974b-831d31923f5024/04/25/16:54:25");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27e31126-0fee-4068-9074-d79bc80fd30a24/04/25/16:54:25");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ddd1490a-7033-4ab3-8660-b62ae660ca8524/04/25/16:54:25");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e821e7a2-7bfb-4eba-a1f2-70b02b39412e24/04/25/16:54:25");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Events");

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
    }
}
