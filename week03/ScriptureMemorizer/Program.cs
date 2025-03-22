using System;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and He will make your paths straight.");

        Console.Write("Enter difficulty (words hidden per step): ");
        int wordsToHide = int.TryParse(Console.ReadLine(), out int difficulty) ? difficulty : 3;

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideWords(wordsToHide);
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
