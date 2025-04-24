// See https://aka.ms/new-console-template for more information
using OOPReview;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Daisy's Car Rental! What Vehicle Would You Like To Rent? (Car, Truck, Motorcycle)");

        string VehicleType = Console.ReadLine();

        if (VehicleType == "Car")
        {
            Vehicle car = new Car();
            Console.WriteLine("How Many Days Would You Like To Rent The Vehicle For?");
            int RentalDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Total Cost Of Your Rental Is: " + car.CalculateRentalCost(RentalDays));
        }
        else if (VehicleType == "Truck")
        {
            Vehicle truck = new Truck();
            Console.WriteLine("How Many Days Would You Like To Rent The Vehicle For?");
            int RentalDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Total Cost Of Your Rental Is: " + truck.CalculateRentalCost(RentalDays));
        }
        else if (VehicleType == "Motorcycle")
        {
            Vehicle motorcycle = new Motorcycle();
            Console.WriteLine("How Many Days Would You Like To Rent The Vehicle For?");
            int RentalDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Total Cost Of Your Rental Is: " + motorcycle.CalculateRentalCost(RentalDays));
        }
        else
        {
            Console.WriteLine("Invalid Vehicle Type");
        }
    }
}
