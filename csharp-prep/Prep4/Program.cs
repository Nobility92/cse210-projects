using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int Number = -1;
        while (Number != 0)
        {
            Console.Write("Enter a number (type 0 to stop): ");
            string answer = Console.ReadLine();
            Number = int.Parse(answer);
            
            // adding the number to the list
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }

        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}