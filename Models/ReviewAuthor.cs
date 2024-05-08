using System.Runtime.InteropServices.Marshalling;

namespace SteamProject.Models
{
    public class ReviewAuthor
    {
        public int Id { get; set; }
        public int Num_Games_Owned { get; set; }
        public int Num_Reviews { get; set; }
        public int Playtime_Forever { get; set; }
        public int Playtime_Last_Two_Weeks { get; set; }
        public int Playtime_At_Review { get; set; }
        public int Last_Played {  get; set; }
    }
}
