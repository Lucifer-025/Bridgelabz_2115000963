using System;

interface IWorker
{
    void PerformDuties();
}

class Person
{
    public string Name;
    public int Id;
}

class Chef : Person, IWorker
{
    public void PerformDuties()
    {
        Console.WriteLine(Name + " is preparing meals.");
    }
}

class Waiter : Person, IWorker
{
    public void PerformDuties()
    {
        Console.WriteLine(Name + " is serving customers.");
    }
}

class Program
{
    static void Main()
    {
        Chef chef = new Chef();
        chef.Name = "Gordon";
        chef.PerformDuties();

        Waiter waiter = new Waiter();
        waiter.Name = "John";
        waiter.PerformDuties();
    }
}
