using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
            return;
        }

        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }

    public void BorrowBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title == title && b.IsAvailable);

        if (book != null)
        {
            book.IsAvailable = false;
            Console.WriteLine($"You borrowed '{title}'");
        }
        else
        {
            Console.WriteLine($"'{title}' is either not available or doesn't exist.");
        }
    }

    public void ReturnBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title == title && !b.IsAvailable);

        if (book != null)
        {
            book.IsAvailable = true;
            Console.WriteLine($"You returned '{title}'");
        }
        else
        {
            Console.WriteLine($"'{title}' was not borrowed or doesn't exist.");
        }
    }

    public void RemoveBook(string title)
    {
        var book = books.FirstOrDefault(b => b.Title == title && b.IsAvailable);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"'{title}' has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"'{title}' is either not available or doesn't exist.");
        }
    }
}
