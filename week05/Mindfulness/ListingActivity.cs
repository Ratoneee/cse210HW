using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string> { "who are people that you appreciate?", "what are personal strengths of yours?", "who are people that you have helped this week?", "who are some of your personal heroes?" };

    public ListingActivity() : base("listing exercise", "this activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("you have a few seconds to think before starting...");
        PauseWithAnimation(5);
        Console.WriteLine("\nstart listing. press enter after each item:");
        List<string> items = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                    items.Add(input);
            }
            Thread.Sleep(1000);
            elapsedTime += 1;
        }
        Console.WriteLine($"\nyou listed {items.Count} items.");
        EndActivity();
    }
}
