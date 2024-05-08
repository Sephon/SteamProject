using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReviewAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num_Games_Owned = table.Column<int>(type: "int", nullable: false),
                    Num_Reviews = table.Column<int>(type: "int", nullable: false),
                    Playtime_Forever = table.Column<int>(type: "int", nullable: false),
                    Playtime_Last_Two_Weeks = table.Column<int>(type: "int", nullable: false),
                    Playtime_At_Review = table.Column<int>(type: "int", nullable: false),
                    Last_Played = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewAuthor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SteamAppId = table.Column<int>(type: "int", nullable: false),
                    RecommendationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp_Created = table.Column<int>(type: "int", nullable: false),
                    Timestamp_Updated = table.Column<int>(type: "int", nullable: false),
                    Voted_Up = table.Column<bool>(type: "bit", nullable: false),
                    Votes_Up = table.Column<int>(type: "int", nullable: false),
                    Votes_Funny = table.Column<int>(type: "int", nullable: false),
                    Weighted_Vote_Score = table.Column<double>(type: "float", nullable: false),
                    Comment_Count = table.Column<int>(type: "int", nullable: false),
                    Steam_Purchase = table.Column<bool>(type: "bit", nullable: false),
                    Recieved_For_Free = table.Column<bool>(type: "bit", nullable: false),
                    Written_During_Early_Access = table.Column<bool>(type: "bit", nullable: false),
                    Hidden_In_Steam_China = table.Column<bool>(type: "bit", nullable: false),
                    Steam_China_Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReview_ReviewAuthor_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ReviewAuthor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReview_Reviews_SteamAppId",
                        column: x => x.SteamAppId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SteamAppId = table.Column<int>(type: "int", nullable: false),
                    Review_Score = table.Column<double>(type: "float", nullable: false),
                    Review_Score_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_Positive = table.Column<int>(type: "int", nullable: false),
                    Total_Negative = table.Column<int>(type: "int", nullable: false),
                    Total_Reviews = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewSummary_Reviews_SteamAppId",
                        column: x => x.SteamAppId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppReview_AuthorId",
                table: "AppReview",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReview_SteamAppId",
                table: "AppReview",
                column: "SteamAppId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewSummary_SteamAppId",
                table: "ReviewSummary",
                column: "SteamAppId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppReview");

            migrationBuilder.DropTable(
                name: "ReviewSummary");

            migrationBuilder.DropTable(
                name: "ReviewAuthor");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
