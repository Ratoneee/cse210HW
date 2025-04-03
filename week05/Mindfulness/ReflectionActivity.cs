using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string> { "think of a time when you stood up for someone else.", "think of a time when you did something really difficult.", "think of a time when you helped someone in need.", "think of a time when you did something truly selfless." };
    private List<string> questions = new List<string> { "why was this experience meaningful to you?", "have you ever done anything like this before?", "how did you get started?", "how did you feel when it was complete?", "what is your favorite thing about this experience?", "what did you learn about yourself through this experience?" };

    public ReflectionActivity() : base("reflection exercise", "this activity will help you reflect on times in your life when you have shown strength and resilience.") {}

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            PauseWithAnimation(5);
            elapsedTime += 5;
        }
        EndActivity();
    }
}
