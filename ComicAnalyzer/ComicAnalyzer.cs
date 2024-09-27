namespace ComicAnalyzer1
{
    public static class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
        {
            if (prices[comic.Issue] < 100M)
            {
                return PriceRange.Cheap;
            }
            return PriceRange.Expensive;
        }


        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> catalog, IReadOnlyDictionary<int, decimal> prices)
        {
            

            var grouping  = 
                from comic in catalog
                orderby prices[comic.Issue]
                group comic by CalculatePriceRange(comic, prices) into comicGroup
                select  comicGroup;
            return grouping;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> catalog, IEnumerable<Review> reviews)
        {
            var reviewsGrouped =
                from comic in catalog
                orderby comic.Issue
                join review in reviews
                on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:F2}";

            return reviewsGrouped;
        }
    }

    public enum PriceRange
    {
        Expensive,
        Cheap,
    }
}

