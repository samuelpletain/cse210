using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        Console.Clear();
        
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            if (scripture.isCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.Clear();
        }
    }
}