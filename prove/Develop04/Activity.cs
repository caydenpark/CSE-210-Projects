using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    public string duration;
    public string activityName;
    public Activity(string name)
    {
        activityName = name;
    }
    public virtual void Description()
    {
        Console.WriteLine("");
    }
    public void StartMessage()
    {
        Console.WriteLine($"\nWelcome to the {activityName} activity.\n");
    }
    public void Duration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = Console.ReadLine();
        Console.WriteLine("Get ready...");
    }
    public void Pause()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];

            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            
            i++;
            
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }
    public virtual void ActualActivities()
    {
        Console.WriteLine("");
    }
    public void EndMessage()
    {
        Console.WriteLine("Well done!\n");
        Console.WriteLine($"You have completed another {duration} seconds of the {activityName} activity.");
    }
}