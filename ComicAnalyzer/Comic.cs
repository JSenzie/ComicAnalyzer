namespace ComicAnalyzer1
{
    public class Comic()
    {
        public string Name = "";
        public int Issue;

        public override string ToString() => $"{Name} (Issue #{Issue})";

        public static readonly IEnumerable<Comic> Catalog = 
            [
                new Comic(){Issue = 6, Name = "Asd"},
                new Comic(){Issue = 19, Name = "zxc"},
                new Comic(){Issue = 57, Name = "qee"},
                new Comic(){Issue = 3, Name = "cvb"}
            ];

        public static readonly IReadOnlyDictionary<int, decimal> Prices =
            new Dictionary<int, decimal>()
            {
                { 6, 30M },
                { 19, 50M },
                { 57, 650M },
                { 3, 12333M }
            };

        public static readonly IEnumerable<Review> Reviews = [
            new Review() { Issue = 6, Critic = Critics.MuddyCritic, Score = 11},
            new Review() { Issue = 57, Critic = Critics.RottenTornadoes, Score = 23},
            new Review() { Issue = 2, Critic = Critics.MuddyCritic, Score = 45},
        ];
    }
}