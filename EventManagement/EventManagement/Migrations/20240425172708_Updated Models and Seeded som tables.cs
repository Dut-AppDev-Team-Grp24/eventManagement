using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class UpdatedModelsandSeededsomtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Venues",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "VenueCapacity",
                table: "Venues",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "20fc4757-7c97-47d5-90cb-ef70b251f26d24/04/25/17:27:07", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "5b7feecf-e65e-4b85-9237-c4a44254c9ec24/04/25/17:27:07", "Music" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "5fa0c2e1-9c6e-4850-9356-0ba89d89e02324/04/25/17:27:07", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "dc74c252-920a-413b-9f30-601fcebaf85a24/04/25/17:27:07", "Movies" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "e16b703f-7f39-4faa-82a4-1487eb940de124/04/25/17:27:07", "Business" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "f9f412a1-0fb1-4d60-a51f-aab8e7d96a6324/04/25/17:27:07", "Conference" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "2583357e-4089-44e5-a315-eaf22404c37024/04/25/17:27:07", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "a302caf0-de8c-4b70-83f2-59f400bdf38124/04/25/17:27:07", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "c71c7110-175e-4eea-85fb-0f52a31fdba524/04/25/17:27:07", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "2a8eaeee-fec3-4867-9a3e-9cc7a7a9564724/04/25/17:27:07", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "a302caf0-de8c-4b70-83f2-59f400bdf38124/04/25/17:27:07", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "a07a08a9-798f-4b66-a21c-086df38d823a24/04/25/17:27:07", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "c71c7110-175e-4eea-85fb-0f52a31fdba524/04/25/17:27:07", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "e2580668-825a-4a5a-960f-87c1e11347ec24/04/25/17:27:07", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "2583357e-4089-44e5-a315-eaf22404c37024/04/25/17:27:07", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "1018c2a8-faf7-4342-875e-2a0de2639e8c24/04/25/17:27:07", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "20fc4757-7c97-47d5-90cb-ef70b251f26d24/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "5b7feecf-e65e-4b85-9237-c4a44254c9ec24/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "5fa0c2e1-9c6e-4850-9356-0ba89d89e02324/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "dc74c252-920a-413b-9f30-601fcebaf85a24/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "e16b703f-7f39-4faa-82a4-1487eb940de124/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "f9f412a1-0fb1-4d60-a51f-aab8e7d96a6324/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2583357e-4089-44e5-a315-eaf22404c37024/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a302caf0-de8c-4b70-83f2-59f400bdf38124/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c71c7110-175e-4eea-85fb-0f52a31fdba524/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2a8eaeee-fec3-4867-9a3e-9cc7a7a9564724/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a07a08a9-798f-4b66-a21c-086df38d823a24/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e2580668-825a-4a5a-960f-87c1e11347ec24/04/25/17:27:07");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "1018c2a8-faf7-4342-875e-2a0de2639e8c24/04/25/17:27:07");

            migrationBuilder.DropColumn(
                name: "VenueCapacity",
                table: "Venues");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Venues",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

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
    }
}
