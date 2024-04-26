using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Update_Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "0a439750-def8-4d1d-b720-9126f227927024/04/26/14:20:11", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "39651772-af5a-4da4-b9fc-b1a099c7787624/04/26/14:20:11", "Movies" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "609c7dea-6661-47e1-9ae8-88b47306adad24/04/26/14:20:11", "Music" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "a3b7e9be-d8b0-41ac-a850-822d8c7b665624/04/26/14:20:11", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "f141ee35-5b5b-4ef5-b2dc-208ba8810aac24/04/26/14:20:11", "Business" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "f982005a-c9ae-427c-9ca6-bfe60d1874c124/04/26/14:20:11", "Conference" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "6a41993e-648a-4341-9487-13a57c29eb5c24/04/26/14:20:11", "EventManager" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "78e48966-14ee-4c3e-ab9a-b509d37ba43424/04/26/14:20:11", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "d55c244b-096c-4994-8aed-044890be13d724/04/26/14:20:11", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "03445fa7-d350-4a88-999d-94bd8f28df7824/04/26/14:20:11", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "d55c244b-096c-4994-8aed-044890be13d724/04/26/14:20:11", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "c3c37a03-e7a3-4041-96db-c2cb2e74b9ed24/04/26/14:20:11", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "6a41993e-648a-4341-9487-13a57c29eb5c24/04/26/14:20:11", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "cb8b06e3-4cfb-440a-8f1e-84e3aed67bb424/04/26/14:20:11", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "78e48966-14ee-4c3e-ab9a-b509d37ba43424/04/26/14:20:11", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "74286808-f371-4e83-ac47-38b894d6efb224/04/26/14:20:11", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventCategoryId",
                table: "Events",
                column: "EventCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventCategories_EventCategoryId",
                table: "Events",
                column: "EventCategoryId",
                principalTable: "EventCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Users_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventCategories_EventCategoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Users_UserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventCategoryId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_VenueId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "0a439750-def8-4d1d-b720-9126f227927024/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "39651772-af5a-4da4-b9fc-b1a099c7787624/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "609c7dea-6661-47e1-9ae8-88b47306adad24/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "a3b7e9be-d8b0-41ac-a850-822d8c7b665624/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "f141ee35-5b5b-4ef5-b2dc-208ba8810aac24/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "f982005a-c9ae-427c-9ca6-bfe60d1874c124/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6a41993e-648a-4341-9487-13a57c29eb5c24/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78e48966-14ee-4c3e-ab9a-b509d37ba43424/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d55c244b-096c-4994-8aed-044890be13d724/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "03445fa7-d350-4a88-999d-94bd8f28df7824/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c3c37a03-e7a3-4041-96db-c2cb2e74b9ed24/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cb8b06e3-4cfb-440a-8f1e-84e3aed67bb424/04/26/14:20:11");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "74286808-f371-4e83-ac47-38b894d6efb224/04/26/14:20:11");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tickets");

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
        }
    }
}
