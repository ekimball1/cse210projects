using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        activities.Add(new Running("15 April 2026", 30, 4.0));
        activities.Add(new Cycling("15 April 2026", 45, 5.0));
        activities.Add(new Swimming("15 April 2026", 25, 15));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}