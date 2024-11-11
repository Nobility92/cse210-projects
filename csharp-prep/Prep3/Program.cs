using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magnum = randomGenerator.Next(1, 101);
        //int magnum = 1;
        int guess = -1;

    while (guess != magnum)
    {
        //Console.WriteLine("What is your Magic Number?");
        //string answer = Console.ReadLine();
        //magnum = int.Parse(answer);
        Console.WriteLine("What is your Guess?");
        string ans = Console.ReadLine();
        guess = int.Parse(ans);

        if (guess == magnum)
        {
            Console.WriteLine("You Guess Right");
        }
        else if (guess > magnum)
        {
            Console.WriteLine("Guess Lower");
        }

        else
        {
            Console.WriteLine("Guess Higher");
        }
        
    }
}
}