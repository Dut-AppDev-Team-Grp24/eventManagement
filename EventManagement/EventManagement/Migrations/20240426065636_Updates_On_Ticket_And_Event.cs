using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    public partial class Updates_On_Ticket_And_Event : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EventStatus",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EventStatus",
                table: "Events");

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
    }
}
