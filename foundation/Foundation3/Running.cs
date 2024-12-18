public class Running : Activity
{
    private double _distance;  // in miles

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;  // Return distance in miles
    }

    public override double GetSpeed()
    {
        return (_distance / minutes) * 60;  // Speed in miles per hour
    }

    public override double GetPace()
    {
        return minutes / _distance;  // Pace in minutes per mile
    }
}
