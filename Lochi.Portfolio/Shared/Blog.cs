namespace Lochi.Portfolio.Shared
{
    public record Blog(string Title, string Summary, DateTime Date, string Content)
        : BlogSummary(Title, Summary, Date);
}
