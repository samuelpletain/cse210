using System;

class Program
{
    /** To exceed the requirements for this assignment, I added a level feature. A menu is displayed before displaying the scripture and the user can pick 4 difficulty levels. The levels behave as follows:
        - Easy: one word is hidden at a time
        - Medium: three words are hidden at a time
        - Hard: Five words are hidden at a time
        - Impossible: Half of the words in the scripture are hidden at a time.

    I also added error messages in case the user inputs were not defined within the scope of the program.
    */

    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        int numberToHide = 0;
        bool error = false;
        
        while (true)
        {
            Console.WriteLine("Choose a dificulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Impossible");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                numberToHide = 1;
                break;
            }
            else if (input == "2")
            {
                numberToHide = 3;
                break;
            }
            else if (input == "3")
            {
                numberToHide = 5;
                break;
            }
            else if (input == "4")
            {
                if (scripture.getScriptureLength() % 2 == 0)
                {
                    numberToHide = scripture.getScriptureLength() / 2;
                }
                else
                {
                    numberToHide = (scripture.getScriptureLength() / 2) + 1;
                }
                break;
            }
            else if (input == "5")
            {
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input.");
                Console.ResetColor();
            }
        }

        Console.Clear();
        
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            if (scripture.isCompletelyHidden())
            {
                Console.WriteLine("Press enter or type 'quit' to finish:");
            }
            else
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                if (error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ResetColor();
                    error = false;
                }
            }
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                if (scripture.isCompletelyHidden())
                {
                    break;
                }
                scripture.HideRandomWords(numberToHide);
                Console.Clear();
            }
            else {
                error = true;
                Console.Clear();
            }
        }
    }
}