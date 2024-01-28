using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please try again.");
                Console.ResetColor();
            }
        }
    }
}