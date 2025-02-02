using System;

class Bookk
{
    public string ISBN;
    protected string Title;
    private string Author;

    public Bookk(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }
}

class EBook : Bookk
{
    public EBook(string isbn, string title, string author) : base(isbn, title, author) { }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"EBook - ISBN: {ISBN}, Title: {Title}");
    }
}

class Program
{
    static void Main()
    {
        EBook ebook = new EBook("12345", "C# Guide", "Alice");
        ebook.DisplayBookDetails();
    }
}
