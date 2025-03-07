using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in a percentage?");
        string input = Console.ReadLine();

        if (float.TryParse(input, out float grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine($"You got a {grade}% so you get an A.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine($"You got a {grade}% so you get a B.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine($"You got a {grade}% so you get a C.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine($"You got a {grade}% so you get a D.");
            }
            else
            {
                Console.WriteLine($"You got a grade below 60% so you get an F.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric grade.");
        }
    }
}
