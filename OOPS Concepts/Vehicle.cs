using System;
using System.Collections.Generic;

abstract class Vehicle
{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle
{
    public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }
}

class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 0.8;
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car("C123", 1000));
        vehicles.Add(new Bike("B456", 500));

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine("Vehicle Number: " + vehicle.vehicleNumber);
            Console.WriteLine("Type: " + vehicle.type);
            Console.WriteLine("Rental Cost for 5 days: " + vehicle.CalculateRentalCost(5));
            Console.WriteLine();
        }
    }
}
