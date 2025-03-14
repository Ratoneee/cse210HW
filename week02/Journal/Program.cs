using System;
using System.Collections.Generic;

class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main()
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
