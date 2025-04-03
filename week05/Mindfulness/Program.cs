using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("mindfulness program");
            Console.WriteLine("1. breathing exercise");
            Console.WriteLine("2. reflection exercise");
            Console.WriteLine("3. listing exercise");
            Console.WriteLine("4. exit");
            Console.Write("choose an option: ");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectionActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4")
            {
                Console.WriteLine("goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("invalid choice, please try again.");
                Console.ReadKey();
            }
        }
    }
}
