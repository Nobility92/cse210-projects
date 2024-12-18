public class Swimming : Activity
{
    private int _laps;  // Number of laps

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceInKm = (_laps * 50) / 1000.0;  // 50 meters per lap, convert to kilometers
        return distanceInKm * 0.62;  // Convert kilometers to miles
    }

    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance();
        return (distanceInMiles / minutes) * 60;  // Speed in miles per hour
    }

    public override double GetPace()
    {
        double distanceInMiles = GetDistance();
        return minutes / distanceInMiles;  // Pace in minutes per mile
    }
}