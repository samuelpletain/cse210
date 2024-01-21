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
                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = promptText,
                    _entryText = entryText
                };
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Added a feature to load to a text or JSON file or display an error message if the extension is not supported
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileName.EndsWith(".txt"))
                {   
                    journal.LoadFromFile(fileName);
                }
                else if (fileName.EndsWith(".json"))
                {
                    journal.LoadFromJSON(fileName);
                }
                else
                {
                    Console.WriteLine("This file extension is not supported.");
                    continue;
                }
            }
            else if (choice == "4")
            {
                // Added a feature to save to a text or JSON file or display an error message if the extension is not supported
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                if (fileName.EndsWith(".txt"))
                {   
                    journal.SaveToFile(fileName);
                }
                else if (fileName.EndsWith(".json"))
                {
                    journal.SaveToJSON(fileName);
                }
                else
                {
                    Console.WriteLine("This file extension is not supported.");
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