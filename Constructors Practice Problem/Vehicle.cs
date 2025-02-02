using System;

class Vehicle
{
    public string OwnerName;
    public string VehicleType;
    public static double RegistrationFee = 100.0;

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle: {VehicleType}, Registration Fee: {RegistrationFee}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    static void Main()
    {
        Vehicle v1 = new Vehicle("Alice", "Car");
        v1.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(120.0);
        Vehicle v2 = new Vehicle("Bob", "Bike");
        v2.DisplayVehicleDetails();
    }
}
