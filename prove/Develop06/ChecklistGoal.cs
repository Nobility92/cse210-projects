/*class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
         _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
         if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        return IsComplete() ? $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}" : $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentaion()
    {
       return $"ChecklistGoal - Goal name: {_shortName} | Description: {_description} | Points: {_points} | Bonus: {_bonus} | Target: {_target} | Completed: {_amountCompleted}";
    }
    public int GetBonusPoints()
    {
        return IsComplete() ? _bonus : 0;
    }
}*/

class ChecklistGoal : Goal
{
    private int _target;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _target)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete() => _currentCount >= _target;

    public override string GetDetailsString() => $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description} (Completed {_currentCount}/{_target})";

    public override string GetStringRepresentation() => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_currentCount}";

    public static ChecklistGoal FromString(string data)
    {
        var parts = data.Split('|');
        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        goal._currentCount = int.Parse(parts[6]);
        return goal;
    }
}
