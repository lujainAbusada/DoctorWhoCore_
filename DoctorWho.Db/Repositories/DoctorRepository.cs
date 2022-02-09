using DoctorWho.Db.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private readonly DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        public void UpdateDoctorName(int doctorId, string newName)
        {
            var doctor = _context.Doctors.Where(a => a.DoctorId == doctorId).FirstOrDefault();
            doctor.DoctorName = newName;
            _context.SaveChanges();
        }

        public void UpdateDoctorNumber(int doctorId, long newNumber)
        {
            var doctor = _context.Doctors.Where(a => a.DoctorId == doctorId).FirstOrDefault();
            doctor.DoctorNumber = newNumber;
            _context.SaveChanges();
        }

        public void UpdateBirthDate(int doctorId, string newBirthDate)
        {
            var doctor = _context.Doctors.Where(a => a.DoctorId == doctorId).FirstOrDefault();
            doctor.BirthDate = newBirthDate;
            _context.SaveChanges();
        }

        public void UpdateFirstEpisodeDate(int doctorId, string newFirstEpisodeDate)
        {
            var doctor = _context.Doctors.Where(a => a.DoctorId == doctorId).FirstOrDefault();
            doctor.FirstEpisodeDate = newFirstEpisodeDate;
            _context.SaveChanges();
        }

        public void UpdateLastEpisodeDate(int doctorId, string newLastEpisodeDate)
        {
            var doctor = _context.Doctors.Where(a => a.DoctorId == doctorId).FirstOrDefault();
            doctor.LastEpisodeDate = newLastEpisodeDate;
            _context.SaveChanges();
        }

        public void InsertDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }
    }
}
