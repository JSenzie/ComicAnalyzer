
namespace ComicAnalyzer1
{
    public class Review
    {
        public int Issue { get; set; }
        public Critics Critic { get; set; }
        public double Score { get; set; }
    }



    public enum Critics
    {
        MuddyCritic,
        RottenTornadoes,
    }
}
