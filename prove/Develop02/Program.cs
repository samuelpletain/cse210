using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{promptText}");
                Console.Write("> ");
                string entryText = Console.ReadLine();
                if (entryText == "")
                {
                    Console.WriteLine("Invalid entry. An entry content cannot be blank.");
                    continue;
                }
                DateTime date = DateTime.Now;
                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = promptText;
                entry._entryText = entryText;
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What file format would you like to use?");
                Console.WriteLine("1. JSON");
                Console.WriteLine("2. Text (.txt)");
                string fileFormat = Console.ReadLine();
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileFormat == "1")
                {   
                    journal.LoadFromJSON(fileName);
                }
                else if (fileFormat == "2")
                {
                    journal.LoadFromFile(fileName);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("What file format would you like to use?");
                Console.WriteLine("1. JSON");
                Console.WriteLine("2. Text (.txt)");
                string fileFormat = Console.ReadLine();
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileFormat == "1")
                {
                    string json = JsonSerializer.Serialize(journal);
                    journal.SaveToJSON(fileName);
                }
                else if (fileFormat == "2")
                {
                    journal.SaveToFile(fileName);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        
    }
}