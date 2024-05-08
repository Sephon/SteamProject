using System.Runtime.InteropServices.Marshalling;

namespace SteamProject.Models
{
    public class AppReview
    {
        public int Id { get; set; }
        public int SteamAppId { get; set; }
        public string RecommendationId { get; set; } = string.Empty;
        public ReviewAuthor? Author { get; set; }
        public string Language { get; set; } = string.Empty;
        public string Review { get; set; } = string.Empty;
        public int Timestamp_Created { get; set; }
        public int Timestamp_Updated { get; set;}
        public bool Voted_Up {  get; set; }
        public int Votes_Up { get; set; }
        public int Votes_Funny { get; set; }
        public double Weighted_Vote_Score { get; set; }
        public int Comment_Count { get; set; }
        public bool Steam_Purchase { get; set; }
        public bool Recieved_For_Free { get; set; }
        public bool Written_During_Early_Access { get; set; }
        public bool Hidden_In_Steam_China { get; set; }
        public string Steam_China_Location { get; set; } = string.Empty;





    }
}
