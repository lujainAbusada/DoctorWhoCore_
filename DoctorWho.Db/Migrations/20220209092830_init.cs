﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Companions",
                columns: table => new
                {
                    CompanionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionName = table.Column<string>(nullable: true),
                    WhoPlayed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companions", x => x.CompanionId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorNumber = table.Column<long>(nullable: false),
                    DoctorName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    FirstEpisodeDate = table.Column<string>(nullable: true),
                    LastEpisodeDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Enemies",
                columns: table => new
                {
                    EnemyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnemyName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemies", x => x.EnemyId);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumber = table.Column<int>(nullable: false),
                    EpisodeNumber = table.Column<int>(nullable: false),
                    EpisodeType = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    EpisodeDate = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.EpisodeId);
                    table.ForeignKey(
                        name: "FK_Episodes_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Episodes_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodeCompanion",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(nullable: false),
                    CompanionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeCompanion", x => new { x.EpisodeId, x.CompanionId });
                    table.ForeignKey(
                        name: "FK_EpisodeCompanion_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "CompanionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeCompanion_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodeEnemy",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(nullable: false),
                    EnemyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeEnemy", x => new { x.EpisodeId, x.EnemyId });
                    table.ForeignKey(
                        name: "FK_EpisodeEnemy_Enemies_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "Enemies",
                        principalColumn: "EnemyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeEnemy_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeCompanion_CompanionId",
                table: "EpisodeCompanion",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeEnemy_EnemyId",
                table: "EpisodeEnemy",
                column: "EnemyId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episodes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episodes",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EpisodeCompanion");

            migrationBuilder.DropTable(
                name: "EpisodeEnemy");

            migrationBuilder.DropTable(
                name: "Companions");

            migrationBuilder.DropTable(
                name: "Enemies");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
