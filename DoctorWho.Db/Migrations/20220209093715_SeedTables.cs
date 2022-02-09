using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Ahmad" },
                    { 2, "Osama" },
                    { 3, "Jamil" },
                    { 4, "Tareq" },
                    { 5, "Rami" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 4, "Ironman", null },
                    { 3, "Captain", null },
                    { 5, "Back Widow", null },
                    { 1, "Thor", null },
                    { 2, "Dr. Strange", null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, "14/02/1999", "Hazem", 599154866L, "05/12/2010", "06/02/2015" },
                    { 2, "29/07/1990", "Malak", 598264767L, "01/01/2015", "16/03/2017" },
                    { 3, "22/10/1998", "Rayyan", 597965571L, "09/02/2013", "06/06/2018" },
                    { 4, "26/06/2000", "Lujain", 597050633L, "15/04/2017", "12/12/2020" },
                    { 5, "25/09/1977", "Fatima", 599856299L, "15/12/2013", "11/03/2015" }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 4, "Immortality", "Glactus" },
                    { 1, "Mind Control", "Thanos" },
                    { 2, "Shapeshifting", "Hela" },
                    { 3, "Invisibility", "Loki" },
                    { 5, "Time travel", "DoomsDay" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "06/02/2015", 1, "Horror", null, 5, "" },
                    { 3, 4, 2, "08/03/2019", 1, "Sci-Fi", null, 5, "Star Wars" },
                    { 5, 3, 2, "16/12/2015", 2, "Comedy", null, 3, "Dumb and Dumber" },
                    { 2, 4, 3, "25/04/2021", 100, "Drama", null, 16, "Legally Blonde" },
                    { 4, 1, 5, "22/10/2018", 22, "Thriller", null, 6, "Fast and Furious" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanion",
                columns: new[] { "EpisodeId", "CompanionId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 3, 5 },
                    { 5, 4 },
                    { 2, 2 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemy",
                columns: new[] { "EpisodeId", "EnemyId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 5 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanion",
                keyColumns: new[] { "EpisodeId", "CompanionId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemy",
                keyColumns: new[] { "EpisodeId", "EnemyId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
