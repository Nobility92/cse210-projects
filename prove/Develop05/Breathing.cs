class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.")
    {

    }
    protected override void Run()
    {
        int cycles = _duration / 6; // Each cycle takes about 6 seconds
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
    }
}