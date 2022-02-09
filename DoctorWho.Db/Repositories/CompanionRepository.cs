using DoctorWho.Db.DataModels;
using System.Linq;


namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {

        private readonly DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void UpdateCompanionName(int companionId, string newName)
        {
            var companion = _context.Companions.Where(a => a.CompanionId == companionId).FirstOrDefault();
            companion.CompanionName = newName;
            _context.SaveChanges();
        }

        public void UpdateWhoPlayed(int companionId, string newWhoPlayed)
        {
            var companion = _context.Companions.Where(a => a.CompanionId == companionId).FirstOrDefault();
            companion.WhoPlayed = newWhoPlayed;
            _context.SaveChanges();
        }

        public void InsertCompanion(Companion companion)
        {
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }

        public void DeleteCompanion(Companion companion)
        {
            _context.Companions.Remove(companion);
            _context.SaveChanges();
        }

        public Companion GetCompanion(int companionId)
        {
            return _context.Companions.Where(c => c.CompanionId == companionId).FirstOrDefault();
        }
    }
}
