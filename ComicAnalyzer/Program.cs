using ComicAnalyzer1;

IEnumerable<IGrouping<PriceRange, Comic>> pricesGroup = ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);

foreach (IGrouping<PriceRange, Comic> item in pricesGroup)
{
    Console.WriteLine(item.Key.ToString());
    foreach(Comic comic in item)
    {
        Console.WriteLine(comic.Name);
    }
}

var reviewsGroup = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);

foreach(string review in reviewsGroup)
{
    Console.WriteLine(review);
}