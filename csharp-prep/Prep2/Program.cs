using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;

        Console.WriteLine("What is your Grade Percentage?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        
        if (grade >= 90)
        {
            letter = 'A';
            //Console.WriteLine("Your grade is A");
        }
        else if (grade >= 80)
        {
            letter = 'B';
            //Console.WriteLine("Your grade is B");
        }
         else if (grade >= 70)
        {
            letter = 'C';
            //Console.WriteLine("Your grade is C");
        }
         else if (grade >= 60)
        {
            letter = 'D';
            //Console.WriteLine("Your grade is D");
        }
        else
        {
            letter = 'F';
         //Console.WriteLine("You Failed");
         Console.WriteLine($"Your grade is {letter}");
        }
        

         if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}