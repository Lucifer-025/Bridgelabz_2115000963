using System;

class CarRental
{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;
    public double CostPerDay = 50.0;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    public double CalculateTotalCost()
    {
        return RentalDays * CostPerDay;
    }

    static void Main()
    {
        CarRental rental1 = new CarRental("John", "Toyota", 5);
        Console.WriteLine("Total Cost: " +rental1.CalculateTotalCost());
    }
}
