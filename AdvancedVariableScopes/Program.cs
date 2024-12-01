
Book book = new Book("grokking algorithms", "Aditya Y. Bhargava");
book.PrintSummary();
Console.WriteLine(book.GetTitleLengthWithoutSpaces());

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"{Title} - {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLengthWithoutSpaces()
    {
        string titleWithoutSpaces = Title.Replace(" ", "");
        return titleWithoutSpaces.Length;
    }
}
