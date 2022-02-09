using DoctorWho.Db.DataModels;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private readonly DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void UpdateSeriesNumber(int episodeId, int newSeriesNumber)
        {
            var episode = _context.Episodes.Where(a => a.EpisodeId == episodeId).FirstOrDefault();
            episode.SeriesNumber = newSeriesNumber;
            _context.SaveChanges();
        }

        public void UpdateEpisodeNumber(int episodeId, int newEpisodeNumber)
        {
            var episode = _context.Episodes.Where(a => a.EpisodeId == episodeId).FirstOrDefault();
            episode.EpisodeNumber = newEpisodeNumber;
            _context.SaveChanges();
        }

        public void UpdateEpisodeType(int episodeId, string newEpisodeType)
        {
            var episode = _context.Episodes.Where(a => a.EpisodeId == episodeId).FirstOrDefault();
            episode.EpisodeType = newEpisodeType;
            _context.SaveChanges();
        }

        public void UpdateTitle(int episodeId, string newTitle)
        {
            var episode = _context.Episodes.Where(a => a.EpisodeId == episodeId).FirstOrDefault();
            episode.Title = newTitle;
            _context.SaveChanges();
        }

        public void UpdateEpisodeDate(int episodeId, string newEpisodeDate)
        {
            var author = _context.Episodes.Where(a => a.EpisodeId == episodeId).FirstOrDefault();
            author.EpisodeDate = newEpisodeDate;
            _context.SaveChanges();
        }

        public void InsertEpisode(Episode episode)
        {
            _context.Episodes.Add(episode);
            _context.SaveChanges();
        }

        public void DeleteEpisode(Episode episode)
        {
            _context.Episodes.Remove(episode);
            _context.SaveChanges();
        }

        public void AddEnemy(Episode episode, int enemyId)
        {
            episode.EpisodeEnemies.Add(new EpisodeEnemy { EnemyId = enemyId });
            _context.Episodes.Attach(episode);
            _context.SaveChanges();
        }

        public void AddCompanion(Episode episode, int companionId)
        {
            episode.EpisodeCompanions.Add(new EpisodeCompanion { CompanionId = companionId });
            _context.Episodes.Attach(episode);
            _context.SaveChanges();
        }
    }
}
