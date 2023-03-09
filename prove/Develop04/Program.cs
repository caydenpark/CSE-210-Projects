using System;

class Program
{
    static void Main(string[] args)
    {
        string activityNumber = " ";
        while (activityNumber != "4")
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            activityNumber = Console.ReadLine();
            ActivityFactory factory = new ActivityFactory();
            Activity activity = factory.CreateActivity(activityNumber);
            
            activity.StartMessage();
            activity.Description();
            activity.Duration();
            activity.Pause();
            activity.ActualActivities();
            activity.EndMessage();
            
        }
    }
}