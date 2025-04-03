using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {name} ---");
        Console.WriteLine(description);
        Console.Write("enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nprepare to begin...");
        PauseWithAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nwell done! you have completed the activity.");
        Console.WriteLine($"you spent {duration} seconds on {name}.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
        }
        Console.WriteLine();
    }
}
