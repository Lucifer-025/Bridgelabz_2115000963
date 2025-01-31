using System;

class Book
{
    private string title;
    private string author;
    private double price;

   
	public void details()
	{
		Console.WriteLine("Enter title");
		title=Console.ReadLine();
		Console.WriteLine("Enter Author");
		author=(Console.ReadLine());
		Console.WriteLine("Enter price");
		price=double.Parse(Console.ReadLine());
	}

    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
		
    }

    static void Main()
    {
        Book book = new Book();
		book.details();
        book.DisplayDetails();
    }
}
