using DoctorWho.Db.DataModels;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private readonly DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void UpdateAuthorName(int authorId, string newName)
        {
            var author = _context.Authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
            author.AuthorName = newName;
            _context.SaveChanges();
        }

        public void InsertAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void DeleteAuthor(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}
