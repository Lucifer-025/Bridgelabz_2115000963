using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class Order
{
    public List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowOrder()
    {
        Console.WriteLine("Order Details:");
        foreach (var product in products)
        {
            Console.WriteLine("Product: " + product.Name + ", Price: Rs" + product.Price);
        }
    }
}

class Customer
{
    public string Name;
    public List<Order> orders = new List<Order>();

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        orders.Add(order);
    }

    public void ShowOrders()
    {
        Console.WriteLine("Customer: " + Name);
        foreach (var order in orders)
        {
            order.ShowOrder();
        }
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer("Shivansh");
        Order order1 = new Order();

        Product product1 = new Product("Laptop", 120000);
        Product product2 = new Product("Phone", 80000);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        customer.PlaceOrder(order1);
        customer.ShowOrders();
    }
}
