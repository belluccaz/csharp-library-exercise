public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvailable = true;
    }

    public void DisplayInfo()
    {
        string status = IsAvailable ? "Available" : "Borrowed";
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Status: {status}");
    }
}
