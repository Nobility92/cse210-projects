public abstract class Activity
{
    // Common properties for all activities
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string date => _date;
    public int minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({minutes} min) - Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}";
    }
}