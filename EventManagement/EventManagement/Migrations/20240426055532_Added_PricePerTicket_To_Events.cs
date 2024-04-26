using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Added_PricePerTicket_To_Events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "PricePerTicket",
                table: "Events",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "02210a9e-fa7a-4d67-9d07-1ec09db1900224/04/26/05:55:31", "Conference" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "20a38da5-7477-4172-bb4f-7306af9216c324/04/26/05:55:31", "Sports" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "6edfebe1-f940-4bd5-bd3a-92183bfe10d024/04/26/05:55:31", "Movies" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "822cfdd5-af39-4db8-8503-84efa4ff7f1724/04/26/05:55:31", "Music" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "aa9b3b1c-d436-4c0e-85a1-b6c04f3b807024/04/26/05:55:31", "Business" });

            migrationBuilder.InsertData(
                table: "EventCategories",
                columns: new[] { "Id", "EventCategoryName" },
                values: new object[] { "e8169d3f-91c9-434f-bb58-1cd1821ce07724/04/26/05:55:31", "Food & Drinks" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "17437a65-9639-45da-b0a7-cf6e6cf487ef24/04/26/05:55:31", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "9c166ae9-6b57-4f90-aa76-eedf0a46d2f324/04/26/05:55:31", "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { "f211c319-4d80-448e-872c-d801121aec9b24/04/26/05:55:31", "EventManager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "394675d2-ec86-4adc-b5b0-c72439c7746f24/04/26/05:55:31", "Durban", "South Africa", "johndoe@event-management.com", "John", "Manager@123", "071231234", "KwaZulu-Natal", "f211c319-4d80-448e-872c-d801121aec9b24/04/26/05:55:31", "123 Eve st", "Doe", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "6741b4b1-b1fe-4f19-b962-62be0055024424/04/26/05:55:31", "Durban", "South Africa", "Sizwe@yahoo.com", "Sizwe", "User@123", "071231234", "KwaZulu-Natal", "9c166ae9-6b57-4f90-aa76-eedf0a46d2f324/04/26/05:55:31", "123 Eve st", "Mchunu", "4000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Email", "Name", "Password", "PhoneNumber", "Province", "RoleId", "StreetAddress", "Surname", "ZipCode" },
                values: new object[] { "92ad3fe7-c293-410e-b3ab-bb5cb09db03424/04/26/05:55:31", "Durban", "South Africa", "admin@event-management.com", "Admin", "Admin@123", "071231234", "KwaZulu-Natal", "17437a65-9639-45da-b0a7-cf6e6cf487ef24/04/26/05:55:31", "123 Eve st", "User", "4000" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "City", "Country", "Price", "Province", "StreetAddress", "VenueCapacity", "VenueDescription", "VenueName", "VenuePictureUrl", "ZipCode" },
                values: new object[] { "9200301b-a839-4877-9d17-44743acd301d24/04/26/05:55:31", "Durban", "South Africa", 500.0, "KwaZulu-Natal", "123 Eve st", 250, "Lion Park Safari Lodge & Conference Center", "Lion Park Safari Lodge & Conference Center", "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png", "4000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "02210a9e-fa7a-4d67-9d07-1ec09db1900224/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "20a38da5-7477-4172-bb4f-7306af9216c324/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "6edfebe1-f940-4bd5-bd3a-92183bfe10d024/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "822cfdd5-af39-4db8-8503-84efa4ff7f1724/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "aa9b3b1c-d436-4c0e-85a1-b6c04f3b807024/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "EventCategories",
                keyColumn: "Id",
                keyValue: "e8169d3f-91c9-434f-bb58-1cd1821ce07724/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "17437a65-9639-45da-b0a7-cf6e6cf487ef24/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9c166ae9-6b57-4f90-aa76-eedf0a46d2f324/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f211c319-4d80-448e-872c-d801121aec9b24/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "394675d2-ec86-4adc-b5b0-c72439c7746f24/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6741b4b1-b1fe-4f19-b962-62be0055024424/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "92ad3fe7-c293-410e-b3ab-bb5cb09db03424/04/26/05:55:31");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "9200301b-a839-4877-9d17-44743acd301d24/04/26/05:55:31");

            migrationBuilder.DropColumn(
                name: "PricePerTicket",
                table: "Events");

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
    }
}
