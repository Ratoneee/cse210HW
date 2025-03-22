using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "trust in the lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\npress enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideWords(3);
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nall words are hidden. program ended.");
    }
}

class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }

    public ScriptureReference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse == null ? $"{Book} {Chapter}:{StartVerse}" : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}

class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

class Scripture
{
    private readonly ScriptureReference reference;
    private readonly List<Word> words;
    private readonly Random random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.ToString().ToLower());
        Console.WriteLine(string.Join(" ", words));
    }

    public void HideWords(int count)
    {
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden);
    }
}
