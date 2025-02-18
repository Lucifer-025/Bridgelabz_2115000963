using System;
using System.Collections.Generic;

abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void Display();
}

class Electronics : WarehouseItem
{
    public Electronics(string name, double price) : base(name, price) { }
    public override void Display() 
    { 
        Console.WriteLine("Electronics: " + Name + ", Price: " + Price); 
    }
}

class Groceries : WarehouseItem
{
    public Groceries(string name, double price) : base(name, price) { }
    public override void Display() 
    { 
        Console.WriteLine("Groceries: " + Name + ", Price: " + Price); 
    }
}

class Furniture : WarehouseItem
{
    public Furniture(string name, double price) : base(name, price) { }
    public override void Display() 
    { 
        Console.WriteLine("Furniture: " + Name + ", Price: " + Price); 
    }
}

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item) 
    { 
        items.Add(item); 
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 1200));
        electronicsStorage.AddItem(new Electronics("Smartphone", 800));

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Table", 300));
        furnitureStorage.AddItem(new Furniture("Chair", 100));

        Console.WriteLine("Electronics Storage:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\nFurniture Storage:");
        furnitureStorage.DisplayItems();
    }
}

