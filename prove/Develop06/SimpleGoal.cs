/*class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        return _isComplete ? $"[X] {_shortName } ({_description})" : $"[ ] {_shortName } ({_description})";
    }
    public override string GetStringRepresentaion()
    {
        return $"Simple Goals - Name: {_shortName} Description: {_description} Points: {_points}";
    }
}*/

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
       return $"[{(_isComplete ? "X" : " ")}] {_shortName} - {_description}";
    } 

    public override string GetStringRepresentation()
    {
       return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    } 

    public static SimpleGoal FromString(string data)
    {
        var parts = data.Split('|');
        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        goal._isComplete = bool.Parse(parts[4]);
        return goal;
    }
}

