using System;

class Program
{
    static void Main(string[] args)
    {
        
        string username = PromptUserName();
       int number = PromptUserNumber();

       int squarenum = SquareNumber(number);

       DisplayResult(username, squarenum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favourite number:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

         static int SquareNumber(int number)
        {
             int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        
    }
}