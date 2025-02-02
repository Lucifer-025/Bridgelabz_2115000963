using System;

class Bookone
{
    public string Title;
    public string Author;
    public double Price;
    public bool Available = true;

    public Bookone(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine(Title +"has been borrowed.");
        }
        else
        {
            Console.WriteLine(Title +"is not available.");
        }
    }

    static void Main()
    {
        Bookone book1 = new Bookone("C# Basics", "Alice", 29.99);
        book1.BorrowBook();
        book1.BorrowBook(); // Trying to borrow again
    }
}
