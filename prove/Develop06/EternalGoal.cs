/*class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
         return $"[ ] {_shortName} ({_description})";
    }
    public override string GetStringRepresentaion()
    {
        return $"Eternal Goals - Name: {_shortName} Description: {_description} Points: {_points}";
    }
}*/

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // No completion state for eternal goals
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
       return $"[ ] {_shortName} - {_description}";
    }
    public override string GetStringRepresentation() 
    {
       return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
    public static EternalGoal FromString(string data)
    {
        var parts = data.Split('|');
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
