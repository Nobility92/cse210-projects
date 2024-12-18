/*public class GoalManager
{
    private static List<Goal> _goals;
    private static int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Delete Goals");
            Console.WriteLine("8. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    Console.WriteLine($"\nTotal Score: {_score}\n");
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    DeleteGoals();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal goal = _goals[choice - 1];
        goal.RecordEvent();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonusPoints();
                Console.WriteLine($"Event recorded for {goal.GetPoints()}. Total Score: {_score}");
            }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private static void ShowGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailString()}");
        }
    }

    private static void SaveGoals()
    {
       Console.Clear();
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully. Press Enter to return to the menu.");
        Console.ReadLine();
    }

    private static void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    if (type == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int targetCount = int.Parse(parts[3]);
                        int bonusPoints = int.Parse(parts[4]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    public void DeleteGoals()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to delete. Press Enter to return to the menu.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }

        Console.Write("Enter the number of the goal to delete: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal goalToDelete = _goals[choice - 1];
            _goals.RemoveAt(choice - 1);
            Console.WriteLine($"Goal \"{goalToDelete.GetShortName()}\" deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice. No goal deleted.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}*/

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest\n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Delete Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Select an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    DeleteGoals();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        var name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        var points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        var typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                var target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                var bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void RecordEvent()
    {
        ShowGoals();
        Console.Write("Select a goal to record (index): ");
        var index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < _goals.Count)
        {
            var goal = _goals[index];
            goal.RecordEvent();
            _score += goal._points;
            Console.WriteLine("Event recorded! Points earned.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (var i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].GetDetailsString()}");
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine($"Your current score: {_score}");
    }

    private void SaveGoals()
    {
        using var writer = new StreamWriter("goals.txt");
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using var reader = new StreamReader("goals.txt");
        _score = int.Parse(reader.ReadLine());
        _goals.Clear();

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(SimpleGoal.FromString(line));
                    break;
                case "EternalGoal":
                    _goals.Add(EternalGoal.FromString(line));
                    break;
                case "ChecklistGoal":
                    _goals.Add(ChecklistGoal.FromString(line));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
   public void DeleteGoals()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to delete. Press Enter to return to the menu.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal to delete: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal goalToDelete = _goals[choice - 1];
            _goals.RemoveAt(choice - 1);
            Console.WriteLine($"Goal \"{goalToDelete._shortName}\" deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice. No goal deleted.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
    
}

