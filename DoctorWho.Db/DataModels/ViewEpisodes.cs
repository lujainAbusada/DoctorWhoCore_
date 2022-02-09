namespace DoctorWho.Db.DataModels
{
    public partial class ViewEpisodes
    {
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public string EpisodeDate { get; set; }
        public string Notes { get; set; }
        public int DoctorId { get; set; }
        public int AuthorId { get; set; }
        public string Authors { get; set; }
        public string Doctors { get; set; }
        public string Enemies { get; set; }
        public string Companions { get; set; }
    }
}
