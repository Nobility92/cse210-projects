using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Henry Nwaokonko", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Wendy Kalu", "Abstraction", "10.5", "5-9");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();
        
        WritingAssignment writingAssignment = new WritingAssignment("David Nwaokonko", "Prose", "Things Fall Apart");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}