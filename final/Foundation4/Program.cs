using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, new DateOnly(2022, 11, 3), 4.8);
        
        Biking biking = new Biking(45, new DateOnly(2023, 3, 15), 25);
    
        Swimming swimming = new Swimming(15, new DateOnly(2024, 6, 29), 40);

        List<Activity> activities = new List<Activity> { running, biking, swimming };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}