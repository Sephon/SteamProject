namespace SteamProject.Models
{
    public class ReviewSummary
    {
        public int Id { get; set; }
        public int SteamAppId { get; set; }
        public double Review_Score { get; set; }
        public string Review_Score_Desc { get; set; } = string.Empty;
        public int Total_Positive { get; set; }
        public int Total_Negative { get; set; }
        public int Total_Reviews { get; set; }
    }
}
