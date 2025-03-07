using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        string playagain;
        
        do
        {
            // picks random number 1-10
            int magicNumber = randomGenerator.Next(1, 10);
            int guess;
            int attempts = 0;
            
            Console.WriteLine("welcome to guess the magic number!");
            
            do
            {
                Console.Write("what is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            } while (guess != magicNumber);
            
            Console.Write("Do you want to play again? (yes/no): ");
            playagain = Console.ReadLine().ToLower();
        } while (playagain == "yes");
        
        Console.WriteLine("Thanks you for playing!");
    }
}
