using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.DataModels
{
    public class Doctor
    {
        public Doctor()
        {
            Episodes = new List<Episode>();
        }

        public int DoctorId { get; set; }
        public long DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public string BirthDate { get; set; }
        public string FirstEpisodeDate { get; set; }
        public string LastEpisodeDate { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
