class Reflection : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."  
    };
    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

     protected override void Run()
    {
        Random random = new();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}

