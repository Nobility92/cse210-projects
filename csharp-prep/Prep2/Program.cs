using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;

        Console.WriteLine("What is your Grade Percentage?");
        int grade = Console.ReadLine();
        
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
        letter = 'F';
         //Console.WriteLine("You Failed");
         Console.WriteLine($"Your grade is {letter}");
    }
}