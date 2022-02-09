using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION fnDoctors (@EpisodeId int)
                                    Returns varchar(1000)
                                    AS
                                    BEGIN 
	                                    DECLARE @Doctors VARCHAR(1000)
	                                    select @Doctors=STRING_AGG(D.DoctorName, ',')   from Doctors D, Episodes E
	                                    where D.DoctorId= E.DoctorId AND E.EpisodeId = @EpisodeId

	                                    return @Doctors
                                    end;");
            migrationBuilder.Sql(@"CREATE FUNCTION fnAuthors (@EpisodeId int)
                                    Returns varchar(1000)
                                    AS
                                    BEGIN 
	                                    DECLARE @Authors VARCHAR(1000)
	                                    select @Authors=STRING_AGG(A.AuthorName, ',')   from Authors A, Episodes E
	                                    where E.AuthorId = A.AuthorId AND E.EpisodeId = @EpisodeId

	                                    return @Authors
                                    end;");
            migrationBuilder.Sql(@"CREATE VIEW viewEpisodes AS(
                                    select  *,
                                    DoctorWhoCore.dbo.fnAuthors(E.EpisodeId) as Authors,
                                    DoctorWhoCore.dbo.fnDoctors(E.EpisodeId) as Doctors,
                                    DoctorWhoCore.dbo.fnEnemies(E.EpisodeId) as Enemies ,
                                    DoctorWhoCore.dbo.fnCompanions(E.EpisodeId) as Companions from Episodes E)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION fnAuthors");
            migrationBuilder.Sql("DROP FUNCTION fnDoctors");
            migrationBuilder.Sql("DROP VIEW viewEpisodes");

        }
    }
}
