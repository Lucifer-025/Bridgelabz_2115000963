using System;
using System.Collections.Generic;
class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        this.Title = title;
        this.Author = author;
    }

    public void Display()
    {
	Console.WriteLine("Book :"+Title);
	Console.WriteLine("Author :"+Author);
    }
}

class Library
{
    public string Name;
    private List<Book> books = new List<Book>();

    public Library(string name)
    {
        this.Name = name;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine("Library :" +Name);
        foreach (var book in books)
        {
            book.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("C# Programming", "Shivansh");
        Book book2 = new Book("Data Structures", "Udit");

        Library lib1 = new Library("Lucknow Library");
        lib1.AddBook(book1);
        lib1.AddBook(book2);

        lib1.ShowBooks();
    }
}
