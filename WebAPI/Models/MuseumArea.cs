namespace WebAPI.Models
{
    public class MuseumArea
    {
        public int AreaID { get; set; }
        public required string AreaName { get; set; }
        public int MaxVisitors { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public int CurrentVisitorCount { get; set; }
    }
}
