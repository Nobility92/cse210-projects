using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new Breathing(),
                "2" => new Reflection(),
                "3" => new Listing(),
                "4" => null,
                _ => throw new InvalidOperationException("Invalid choice.")
            };

            if (activity == null)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            activity.DisplayStartingMessage();
        }
    }
}