namespace SteamProject.Models
{
    public class SteamApp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ReviewSummary ReviewSummary { get; set; }
        public List<AppReview>? Reviews { get; set; }

        public SteamApp() { }
    }
}
