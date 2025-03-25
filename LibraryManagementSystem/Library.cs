using System;

public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddPatron(Person patron)
    {
        Patrons.Add(patron);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
        Console.WriteLine();
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("Patrons in Library:");
        foreach (var patron in Patrons)
        {
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
        }
        Console.WriteLine();
    }

    public void BorrowBook(string patronName, string bookTitle)
    {
        var book = Books.FirstOrDefault(b => b.Title == bookTitle);
        if (book != null && book.BorrowBook())
        {
            Console.WriteLine($"{patronName} borrowed '{bookTitle}'");
        }
        else
        {
            Console.WriteLine($"Sorry, '{bookTitle}' is not available.");
        }
    }
}

