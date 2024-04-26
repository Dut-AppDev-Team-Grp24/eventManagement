using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Removed_TicketId_OnVenue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TicketId",
                table: "Events");

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "6168f89a-c318-41bf-bd37-cd2b93846bd024/04/26/08:33:09", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "74bcf385-0e49-4f4f-998e-5e85e75cc16e24/04/26/08:33:09", "Movies" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "780a44e6-ba72-4eb4-a9f6-9627fdaf758d24/04/26/08:33:09", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "e1a03fce-af80-457f-bb6b-be6b234fd4ef24/04/26/08:33:09", "Conference" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "e76a35fb-bb1c-4a60-8d8a-9d5d6874dc1424/04/26/08:33:09", "Business" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "f61653bd-2d55-47e2-9460-23bc40b3b1bf24/04/26/08:33:09", "Music" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "27cadb42-3344-455b-89a1-ef6fc81e128524/04/26/08:33:09", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "64d5f43f-1744-4b39-a1f8-a8b91d16ffa724/04/26/08:33:09", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "66092068-5522-4b53-add9-0b9fa1daa2ae24/04/26/08:33:09", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "10986170-d0f0-4cbd-8702-11576cbfc67324/04/26/08:33:09", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "27cadb42-3344-455b-89a1-ef6fc81e128524/04/26/08:33:09", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "463c7083-04dc-4cf6-80a8-d62cc58ac01224/04/26/08:33:09", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "66092068-5522-4b53-add9-0b9fa1daa2ae24/04/26/08:33:09", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "eacb90a9-f6f9-40b5-81b5-485d1952961d24/04/26/08:33:09", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "64d5f43f-1744-4b39-a1f8-a8b91d16ffa724/04/26/08:33:09", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "b6d54661-6bf8-481d-bd2d-a912972b26f324/04/26/08:33:09", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "6168f89a-c318-41bf-bd37-cd2b93846bd024/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "74bcf385-0e49-4f4f-998e-5e85e75cc16e24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "780a44e6-ba72-4eb4-a9f6-9627fdaf758d24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "e1a03fce-af80-457f-bb6b-be6b234fd4ef24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "e76a35fb-bb1c-4a60-8d8a-9d5d6874dc1424/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "f61653bd-2d55-47e2-9460-23bc40b3b1bf24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "27cadb42-3344-455b-89a1-ef6fc81e128524/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "64d5f43f-1744-4b39-a1f8-a8b91d16ffa724/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66092068-5522-4b53-add9-0b9fa1daa2ae24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10986170-d0f0-4cbd-8702-11576cbfc67324/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "463c7083-04dc-4cf6-80a8-d62cc58ac01224/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eacb90a9-f6f9-40b5-81b5-485d1952961d24/04/26/08:33:09");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "b6d54661-6bf8-481d-bd2d-a912972b26f324/04/26/08:33:09");

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
    }
}
