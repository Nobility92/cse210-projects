class Listing : Activity
{
     private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void Run()
    {
        Random random = new();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("You have a few seconds to prepare...");
        ShowCountDown(5);
        Console.WriteLine("Start listing now:");

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}