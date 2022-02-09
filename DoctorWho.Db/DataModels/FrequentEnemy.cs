namespace DoctorWho.Db.DataModels
{
    public class FrequentEnemy : IFrequentCharacters
    {
        public int EnemyId { get; set; }
        public int Frequency { get; set; }
    }
}
