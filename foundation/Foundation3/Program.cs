using System;

class Program
{
    static void Main(string[] args)
    {
   
        List<Activity> activities = new List<Activity>
        {
            new Running("17 Dec 2024", 30, 3.0),  // Running activity: 30 min, 3 miles
            new Running("17 Dec 2024", 30, 4.8),  // Running activity: 30 min, 4.8 km (converted in GetDistance)
            new Cycling("17 Dec 2024", 45, 15.0),  // Cycling activity: 45 min, 15 mph
            new Swimming("17 Dec 2024", 40, 30)   // Swimming activity: 40 min, 30 laps
        };

        // Display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    
    }
}