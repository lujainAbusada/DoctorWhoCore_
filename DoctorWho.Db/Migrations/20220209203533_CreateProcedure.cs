using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    CREATE PROCEDURE spSummariseEpisodes
                                    AS BEGIN
  
                                    Select top(3)  EC.CompanionId,COUNT(EC.CompanionId) as number from Companions C, EpisodeCompanion EC
                                    where C.CompanionId = EC.CompanionId
                                    Group by EC.CompanionId


                                    Select top(3)  EE.EnemyId,Count(E.EnemyId) as number from Enemies E, EpisodeEnemy EE
                                    where E.EnemyId = EE.EnemyId
                                    Group by EE.EnemyId
                                    END;");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS spSummariseEpisodes;");

        }
    }
}
