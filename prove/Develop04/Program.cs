using System;

class Program
{
    /** To exceed expectations, I created an extra type of activity, FiveSensesActivity. This activity uses the duration differently than the others by dividing the time given by the number of senses in the senses list. I also added error handling for the main menu. */

    static void Main(string[] args)
    {
        bool error = false;

        while(true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start five senses activity (requires at least 50 seconds)");
            Console.WriteLine("  5. Quit");

            if (error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please try again.");
                Console.ResetColor();
                error = false;
            }

            Console.Write("Select a choice from the menu: ");
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
                FiveSensesActivity fiveSensesActivity = new FiveSensesActivity();
                fiveSensesActivity.Run();
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                error = true;
            }
        }
    }
}