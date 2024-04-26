using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Import_New_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "0cdbac8e-35f0-45e1-9a82-3063ee1d4fe324/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "2271e835-88b9-438a-a716-546481a0b24324/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "41a9cf17-a888-4ee7-a247-79ef1458996524/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "a493dece-9a15-4c40-b226-e742eaaed0b224/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "c84fe682-60ec-40d3-8154-3d05ec62316124/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "cc2acece-c976-41ac-8232-11c9e0fdbb5924/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0b5228fa-8d69-40f3-b878-788f876e7ee624/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "10f4f77f-ad5e-4207-86c4-b337a63b72d224/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bd9406a2-f119-488f-9ceb-85b40d9946fc24/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "015192bc-f4f0-42a4-bc09-0967bcf256a024/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ff1992e-0c7f-4043-91bb-8ef9bcff3f7324/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "786ffce4-976f-4d14-98a7-271917114e1b24/04/26/06:56:35");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "15f1d65a-445f-4b97-b456-3a558cbac71e24/04/26/06:56:35");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Tickets",
                newName: "type");

            migrationBuilder.AddColumn<double>(
                name: "Commission",
                table: "Tickets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Tickets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "VAT",
                table: "Tickets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TicketId",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "7178f2e1-e75d-473f-b9dc-80f94f403d0d24/04/26/08:12:18", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "83754b46-f7a7-443e-9a2d-e5b908a807c424/04/26/08:12:18", "Movies" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "8ce7d4d8-b28b-4e93-8e86-57e9fff766f424/04/26/08:12:18", "Conference" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "ec63d38e-b672-4aba-92e3-3b54c1cc29d424/04/26/08:12:18", "Music" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "f7b2267b-1d77-44a9-8cc0-b2d85582735b24/04/26/08:12:18", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "fcf094b2-b445-4b7b-b2e6-88095218a79b24/04/26/08:12:18", "Business" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "36d35280-cd28-459d-a614-145bc35159d624/04/26/08:12:18", "EventManager" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "40cfdef8-c6b9-4052-ac15-fd1a0cd3682b24/04/26/08:12:18", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "86d6064c-c71b-41e0-823f-d3fd77c0ac6424/04/26/08:12:18", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "4e27594b-b223-4e93-9d2e-cd69050f447224/04/26/08:12:18", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "36d35280-cd28-459d-a614-145bc35159d624/04/26/08:12:18", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "64724da9-4a47-4060-bd46-78608228485524/04/26/08:12:18", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "40cfdef8-c6b9-4052-ac15-fd1a0cd3682b24/04/26/08:12:18", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "d1feccb0-7312-43d2-876f-c242f923d4be24/04/26/08:12:18", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "86d6064c-c71b-41e0-823f-d3fd77c0ac6424/04/26/08:12:18", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "9c41231c-44a5-4bd3-9294-0ec9ba5ba7aa24/04/26/08:12:18", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "7178f2e1-e75d-473f-b9dc-80f94f403d0d24/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "83754b46-f7a7-443e-9a2d-e5b908a807c424/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "8ce7d4d8-b28b-4e93-8e86-57e9fff766f424/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "ec63d38e-b672-4aba-92e3-3b54c1cc29d424/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "f7b2267b-1d77-44a9-8cc0-b2d85582735b24/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "fcf094b2-b445-4b7b-b2e6-88095218a79b24/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "36d35280-cd28-459d-a614-145bc35159d624/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "40cfdef8-c6b9-4052-ac15-fd1a0cd3682b24/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "86d6064c-c71b-41e0-823f-d3fd77c0ac6424/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4e27594b-b223-4e93-9d2e-cd69050f447224/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "64724da9-4a47-4060-bd46-78608228485524/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d1feccb0-7312-43d2-876f-c242f923d4be24/04/26/08:12:18");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "9c41231c-44a5-4bd3-9294-0ec9ba5ba7aa24/04/26/08:12:18");

            migrationBuilder.DropColumn(
                name: "Commission",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "VAT",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Tickets",
                newName: "Type");

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "0cdbac8e-35f0-45e1-9a82-3063ee1d4fe324/04/26/06:56:35", "Business" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "2271e835-88b9-438a-a716-546481a0b24324/04/26/06:56:35", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "41a9cf17-a888-4ee7-a247-79ef1458996524/04/26/06:56:35", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "a493dece-9a15-4c40-b226-e742eaaed0b224/04/26/06:56:35", "Music" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "c84fe682-60ec-40d3-8154-3d05ec62316124/04/26/06:56:35", "Conference" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "cc2acece-c976-41ac-8232-11c9e0fdbb5924/04/26/06:56:35", "Movies" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "0b5228fa-8d69-40f3-b878-788f876e7ee624/04/26/06:56:35", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "10f4f77f-ad5e-4207-86c4-b337a63b72d224/04/26/06:56:35", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "bd9406a2-f119-488f-9ceb-85b40d9946fc24/04/26/06:56:35", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "015192bc-f4f0-42a4-bc09-0967bcf256a024/04/26/06:56:35", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "bd9406a2-f119-488f-9ceb-85b40d9946fc24/04/26/06:56:35", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "4ff1992e-0c7f-4043-91bb-8ef9bcff3f7324/04/26/06:56:35", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "10f4f77f-ad5e-4207-86c4-b337a63b72d224/04/26/06:56:35", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "786ffce4-976f-4d14-98a7-271917114e1b24/04/26/06:56:35", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "0b5228fa-8d69-40f3-b878-788f876e7ee624/04/26/06:56:35", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "15f1d65a-445f-4b97-b456-3a558cbac71e24/04/26/06:56:35", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });
        }
    }
}
