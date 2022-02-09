using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateFunctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION fnCompanions(@EpisodeId int)
                                        Returns varchar(1000)
                                        AS
                                        BEGIN

                                            DECLARE @Companions VARCHAR(1000)

                                            select @Companions = STRING_AGG(C.CompanionName, ',') from Companions C, EpisodeCompanion EC, Episodes E
                                              where C.CompanionId = EC.CompanionId AND E.EpisodeId = EC.EpisodeId

                                            AND EC.EpisodeId = @EpisodeId


                                            return @Companions
                                        end;

            ");

            migrationBuilder.Sql(@"CREATE FUNCTION fnEnemies (@EpisodeId int)
                                Returns varchar(1000)
                                AS
                                BEGIN 
	                                DECLARE @Enemies VARCHAR(1000)
	                                select @Enemies=STRING_AGG(EN.EnemyName, ',')   from Enemies EN, EpisodeEnemy EE, Episodes E
	                                where EN.EnemyId = EE.EnemyId AND E.EpisodeId = EE.EpisodeId
	                                AND EE.EpisodeId = @EpisodeId

	                                return @Enemies
                                end;

                                            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION fnEnemies");
            migrationBuilder.Sql("DROP FUNCTION fnCompanions");
        }
    }
}
