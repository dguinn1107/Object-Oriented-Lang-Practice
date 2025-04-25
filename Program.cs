// See https://aka.ms/new-console-template for more information
using OOPReview.Models;

public static class Program
{
    public static void Main(string[] args) {
     
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Welcome to the OOP Review! Please select an option: 1. User, 2. Vehicle Rental [1, 2]");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    RunUser();
                    break;
                case 2:
                    RunVehicleRental();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.WriteLine("Do you want to go again? (yes/no)");
            string restartInput = Console.ReadLine().ToLower();

            if (restartInput != "yes")
            {
                keepRunning = false;
                Console.WriteLine("Thanks for playing! Goodbye.");
            }
            else
            {
                Console.Clear(); // Optional: clears console for a clean start
            }
        }
    }








public static void RunUser()
    {

        Console.WriteLine("Hello! You have a few options. 1. Tell me who you are, 2. Make a baby, 3. Meet somebody new. [1, 2, 3]");
        int userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput) {
            case 1:
                User user = new User();
                Console.WriteLine("Great! I'd love to learn more about you. What is your name?");
                user.Name = Console.ReadLine();
                Console.WriteLine("And how old are you, " + user.Name + "?");
                user.Age = Convert.ToInt32(Console.ReadLine());

                if (user.Age < 70)
                {
                    Console.WriteLine("Wow! Your young.");
                }
                else
                {
                    Console.WriteLine("Old but gold baby");
                }


                    break;

            case 2:
                user = new User();
                Console.WriteLine("Now this is where the magic happens! Are you ready to push?");

               string YesOrNo =  Console.ReadLine();
                
                if (YesOrNo == "yes")
                {
                    user.IsStranger = false;
                    user.Age = 0;
                    
                    string[] randomGender = { "female", "male" };
                    Random random = new Random();
                    int index = random.Next(randomGender.Length);
                    string selectedItem = randomGender[index];
                    Console.WriteLine($"Suprise it's a {selectedItem}" + "!");
                }

                else if(YesOrNo == "no")
                {
                    Console.WriteLine("I will schedule your funeral.");
                    return;
                }
                else
                {
                    Console.WriteLine("Come on type yes or no bruh.");
                }




                    Console.WriteLine("What is your new baby's name?");


                user.Name = Console.ReadLine();
                Console.WriteLine(user.Name + ", What a wonderful name. Are you happy with how it looks?");

                string isUserHappy = Console.ReadLine();

                if (isUserHappy == "yes")
                {
                    Console.WriteLine("Enjoy your new baby!");
                }
                else
                {
                    Console.WriteLine("Okay. Give it here, I'll throw it away.");
                }






                




                break;

            case 3:
                user = new User();
                Console.WriteLine("Great! Let me go get somebody for you to meet.");
               
                
                user.Name = "Bob";
                user.Age = 25;
                user.Gender = "female";

                Console.WriteLine("Are you ready to meet them?");
                string ready = Console.ReadLine();
                if (ready.Equals("yes"))
                {
                    Console.WriteLine("Ask thier name! Don't be rude");
                    
                }
                else
                {
                    Console.WriteLine("Bro, don't waste my time.");
                }
                Console.ReadLine();
                Console.WriteLine("Stranger: Do I know you?") ;
                
               string friends = Console.ReadLine();

                if (friends.Equals("yes"))
                {
                    user.IsStranger = false;
                    Console.WriteLine("Stranger: My name is " + user.Name + ". I am " + user.Age + " and I am a " + user.Gender);

                }
                else
                {
                    user.IsStranger= true;
                    Console.WriteLine("Get away stranger!");
                }
                



                break;









        }
    }
    public static void RunVehicleRental()
    {
        //data abstraction

        Console.WriteLine("Welcome to Daisy's Car Rental! It Cost $50 Per Day To Rent A Car, $100 Per Day To Rent A Truck For The First 3 Days, And $120 Per Day After That, And $15 Per Day To Rent A Motorcycle. Please Enter The Vehicle Type You Would Like To Rent (Car, Truck, Motorcycle)");

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


