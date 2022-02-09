using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho.Db.DataModels
{
    public class FrequentCompanion : IFrequentCharacters
    {
        public int CompanionId { get; set; }
        public int Frequency { get; set; }
    }
}
