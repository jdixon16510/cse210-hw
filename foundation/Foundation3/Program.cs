using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("03 Nov 2022", 40, 25),
            new Swimming("03 Nov 2022", 45, 40)
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}