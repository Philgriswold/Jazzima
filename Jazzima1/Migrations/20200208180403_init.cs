using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jazzima1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavedAlbums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedAlbums_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    AlbumId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musician",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Instrument = table.Column<string>(nullable: true),
                    InstrumentTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musician_InstrumentType_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicianAlbum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicianId = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianAlbum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicianAlbum_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianAlbum_Musician_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musician",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "https://upload.wikimedia.org/wikipedia/en/7/7a/Maiden_Voyage_%28Hancock%29.jpg", 1965, "Maiden Voyage" },
                    { 13, "https://upload.wikimedia.org/wikipedia/en/9/94/AT%27s_Delight.jpg", 1960, "A.T's Delight" },
                    { 12, "https://upload.wikimedia.org/wikipedia/en/d/d1/Open_Sesame_%28Freddie_Hubbard_album%29.jpg", 1960, "Open Sesame" },
                    { 11, "https://upload.wikimedia.org/wikipedia/en/f/f1/Davis_Cup_%28album%29.jpg", 1960, "Davis Cup" },
                    { 10, "https://upload.wikimedia.org/wikipedia/en/7/78/New_Soil.jpg", 1959, "New Soil" },
                    { 8, "https://upload.wikimedia.org/wikipedia/en/3/32/Newk%27s_Time.jpeg", 1959, "Newk's Time" },
                    { 9, "https://upload.wikimedia.org/wikipedia/en/0/0e/Off_to_the_Races.jpg", 1959, "Off To The Races" },
                    { 6, "https://upload.wikimedia.org/wikipedia/en/e/ec/The_Cooker.jpg", 1958, "The Cooker" },
                    { 5, "https://upload.wikimedia.org/wikipedia/en/6/68/John_Coltrane_-_Blue_Train.jpg", 1958, "Blue Train" },
                    { 4, "https://upload.wikimedia.org/wikipedia/en/c/c0/Horace_Silver_and_the_Jazz_Messengers.jpg", 1956, "Horace Silver and The Jazz Messengers" },
                    { 3, "https://upload.wikimedia.org/wikipedia/en/4/41/The_Soothsayer.jpg", 1979, "The Soothsayer" },
                    { 2, "https://upload.wikimedia.org/wikipedia/en/4/4a/Point_of_Departure.jpg", 1965, "Point Of Departure" },
                    { 7, "https://upload.wikimedia.org/wikipedia/commons/a/ad/Somethin%E2%80%99_Else.jpg", 1958, "Somethin' Else" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "e9a17796-07ad-4026-bf0f-dcd288ce9e1b", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAnO9n+0kZv2Raoe36y4aq1jDZWcPu9q56zPIotGNRbWlz+TyXyQ6Yv+IDUNNuX+9Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "InstrumentType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 3, "Bass" },
                    { 1, "Horn" },
                    { 2, "Piano" },
                    { 4, "Drums" }
                });

            migrationBuilder.InsertData(
                table: "Musician",
                columns: new[] { "Id", "Instrument", "InstrumentTypeId", "Name" },
                values: new object[,]
                {
                    { 31, "trumpet", 1, "Miles Davis" },
                    { 37, "alto saxophone", 1, "Jackie McLean" },
                    { 43, "tenor saxophone", 1, "Stanley Turrentine" },
                    { 2, "piano", 2, null },
                    { 5, "piano", 2, "Herbie Hancock" },
                    { 13, "piano", 2, "Andrew Hill" },
                    { 17, "piano", 2, "McCoy Tyner" },
                    { 18, "piano", 2, "Horace Silver" },
                    { 24, "piano", 2, "Kenny Drew" },
                    { 28, "piano", 2, "Bobby Timmons" },
                    { 32, "piano", 2, "Hank Jones" },
                    { 33, "piano", 2, "Sam Jones" },
                    { 36, "trumpet", 1, "Donald Byrd" },
                    { 35, "piano", 2, "Wynton Kelly" },
                    { 3, "bass", 3, null },
                    { 8, "bass", 3, "Ron Carter" },
                    { 14, "bass", 3, "Richard Davis" },
                    { 20, "bass", 3, "Doug Watkins" },
                    { 23, "bass", 3, "Paul Chambers" },
                    { 38, "bass", 3, "Sam Jones" },
                    { 4, "drums", 4, null },
                    { 9, "drums", 4, "Tony Williams" },
                    { 21, "drums", 4, "Art Blakey" },
                    { 22, "drums", 4, "Philly Joe Jones" },
                    { 39, "drums", 4, "Art Taylor" },
                    { 40, "piano", 2, "Walter Davis Jr." },
                    { 34, "tenor saxophone", 1, "Sonny Rollins" },
                    { 42, "drums", 4, "Clifford Jarvis" },
                    { 30, "alto saxophone", 1, "Cannonball Adderley" },
                    { 41, "drums", 4, "Pete La Roca" },
                    { 6, "trumpet", 1, "Freddie Hubbard" },
                    { 7, "tenor saxophone", 1, "George Coleman" },
                    { 10, "trumpet", 1, "Kenny Dorham" },
                    { 11, "alto saxophone", 1, "Eric Dolphy" },
                    { 12, "tenor saxophone", 1, "Joe Henderson" },
                    { 1, "horns", 1, null },
                    { 16, "alto saxophone", 1, "James Spaulding" },
                    { 19, "tenor saxophone", 1, "Hank Mobley" },
                    { 25, "trombone", 1, "Curtis Fuller" },
                    { 26, "trumpet", 1, "Lee Morgan" },
                    { 27, "tenor saxophone", 1, "John Coltrane" },
                    { 29, "baritone saxophone", 1, "Pepper Adams" },
                    { 15, "tenor saxophone", 1, "Wayne Shorter" }
                });

            migrationBuilder.InsertData(
                table: "SavedAlbums",
                columns: new[] { "Id", "AlbumId", "UserId" },
                values: new object[,]
                {
                    { 2, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, 3, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, 4, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, 5, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, 6, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, 10, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, 8, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, 9, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, 11, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, 12, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, 13, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, 7, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, 1, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "MusicianAlbum",
                columns: new[] { "Id", "AlbumId", "MusicianId" },
                values: new object[,]
                {
                    { 2, 1, 6 },
                    { 35, 7, 32 },
                    { 36, 7, 33 },
                    { 39, 8, 35 },
                    { 45, 9, 35 },
                    { 63, 13, 35 },
                    { 50, 10, 40 },
                    { 53, 11, 40 },
                    { 15, 1, 8 },
                    { 16, 3, 8 },
                    { 9, 2, 14 },
                    { 20, 4, 20 },
                    { 40, 8, 20 },
                    { 26, 5, 23 },
                    { 31, 6, 23 },
                    { 51, 10, 23 },
                    { 64, 13, 23 },
                    { 46, 9, 38 },
                    { 56, 11, 38 },
                    { 60, 12, 38 },
                    { 13, 1, 9 },
                    { 14, 2, 9 },
                    { 21, 4, 21 },
                    { 37, 7, 21 },
                    { 27, 5, 22 },
                    { 32, 6, 22 },
                    { 41, 8, 22 },
                    { 47, 9, 39 },
                    { 57, 11, 39 },
                    { 65, 13, 39 },
                    { 30, 6, 28 },
                    { 52, 10, 41 },
                    { 24, 5, 24 },
                    { 59, 12, 17 },
                    { 3, 3, 6 },
                    { 58, 12, 6 },
                    { 4, 1, 7 },
                    { 5, 2, 10 },
                    { 18, 4, 10 },
                    { 6, 2, 11 },
                    { 7, 2, 12 },
                    { 10, 3, 15 },
                    { 11, 3, 16 },
                    { 19, 4, 19 },
                    { 23, 5, 25 },
                    { 25, 5, 26 },
                    { 28, 6, 26 },
                    { 22, 5, 27 },
                    { 29, 6, 29 },
                    { 44, 9, 29 },
                    { 33, 7, 30 },
                    { 34, 7, 31 },
                    { 38, 8, 34 },
                    { 42, 9, 36 },
                    { 49, 10, 36 },
                    { 54, 11, 36 },
                    { 43, 9, 37 },
                    { 48, 10, 37 },
                    { 55, 11, 37 },
                    { 62, 13, 43 },
                    { 1, 1, 5 },
                    { 8, 2, 13 },
                    { 12, 3, 17 },
                    { 17, 4, 18 },
                    { 61, 12, 42 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AlbumId",
                table: "Comments",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Musician_InstrumentTypeId",
                table: "Musician",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianAlbum_AlbumId",
                table: "MusicianAlbum",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianAlbum_MusicianId",
                table: "MusicianAlbum",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAlbums_AlbumId",
                table: "SavedAlbums",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "MusicianAlbum");

            migrationBuilder.DropTable(
                name: "SavedAlbums");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Musician");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "InstrumentType");
        }
    }
}
