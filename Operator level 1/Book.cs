using System;
class Book
{
    public static string LibraryName="Union Library";
    private readonly string ISBN;
    public  string Title;
    public  string Author;
    public Book(string title, string author, string isbn)
    {
        this.Author = author;
        this.Title = title;
        this.ISBN = isbn;   
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name :" + LibraryName);
    }
    public void displaybookdetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Book Name :" + Title);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("ISBN :" + ISBN);
        }
    }
 static void Main()
 {
     Book bk1 = new Book("After we fell","Alice","15256");
     Book bk2 = new Book("After we Collided", "Persia", "16256");
     bk1.displaybookdetails();
     bk2.displaybookdetails();
     Book.DisplayLibraryName();
 }

}