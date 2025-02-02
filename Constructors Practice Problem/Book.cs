using System;

class Book
{
    private string title;
    private string author;
    private double price;

   
	public Book()
	{
		this.title="Noname";
		this.author="Noname";
		this.price=0;
	}
	public Book(string a, string b , int c)
	{
		title=a;
		author=b;
		price=c;
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
		Book book1 = new Book("Trapped","Selena",5000);
		
        book.DisplayDetails();
		book1.DisplayDetails();
	
    }
}
