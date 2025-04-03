using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("breathing exercise", "this activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.") {}

    public void Run()
    {
        StartActivity();
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.Write("breathe in... ");
            PauseWithAnimation(3);
            Console.Write("breathe out... ");
            PauseWithAnimation(3);
            elapsedTime += 6;
        }
        EndActivity();
    }
}
