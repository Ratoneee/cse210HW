using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = Regex.Matches(text, @"[\w']+|[.,!?;]")
                      .Select(match => new Word(match.Value))
                      .ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine(string.Join(" ", _words));
    }

    public void HideWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
