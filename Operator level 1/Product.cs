using System;
class Product
{
    private static double Discount;
    private readonly int ProductID;
    public string ProductName;
	public int Price;
	public int Quantity;
	public Product(string productName,int price, int quantity,int productid)
	{ 
	this.ProductName=productName;
	this.Price=price;
	this.Quantity=quantity;
	this.ProductID=productid;;
	}
	
	public static void UpdateDiscount(double amt)
	{
       Discount=amt;
	Console.WriteLine("Total Discount :"+Discount);
	}
	public void displayproductdetails()
	{
	if(this is Product)
	{
	Console.WriteLine("ProductName :"+ProductName);
	Console.WriteLine("Price  :"+Price);
	Console.WriteLine("Quantity :"+Quantity);
	Console.WriteLine("ProductID :"+ProductID);
	}
	}
	static void Main()
	{
	Product product1=new Product("Asus Tuf Gaming",70000,1,122151);
	Product product2=new Product("Samsung Mobile",60000,2,125486);
	product1.displayproductdetails();
     UpdateDiscount(10);
	product2.displayproductdetails();
     UpdateDiscount(15);
	}
	}