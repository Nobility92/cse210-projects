using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        Run();
        DisplayEndingMessage();
    }

     protected abstract void Run();
     public void DisplayEndingMessage()
    {
       Console.WriteLine("Good job! Activity complete.");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3); 
    }
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]} Preparing...");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}