using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

class Listing : Activity
{
    public Listing():base("Listing")
    {
        
    }
    public override void Description()
    {
        Console.WriteLine("This activity will help you reflect on "
        +"the good things in your life by having you list as many "
        +"things as you can in a certain area.\n");
    }
    public override void ActualActivities()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        
        Random randomP = new Random();
        int randomIndexP = randomP.Next(prompts.Count);
        string randomPrompt = prompts[randomIndexP];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {randomPrompt} ---");

        List<string> animationCountdown = new List<string>();
        animationCountdown.Add("4");
        animationCountdown.Add("3");
        animationCountdown.Add("2");
        animationCountdown.Add("1");
        animationCountdown.Add("0");

        int durationInt;
        durationInt = int.Parse(duration);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        Console.Write("\nYou may begin in: \n");

        for (int i = 0; i < animationCountdown.Count; i ++)
        {
            string countDown = animationCountdown[i];
            Console.Write(countDown);
            Thread.Sleep(1500);
            Console.Write("\b \b");
        }

        string line;
        int lineCount = 0;

        while (stopwatch.Elapsed.Seconds <= durationInt)
        {
            Console.Write("> ");
            line = Console.ReadLine();
            //Console.WriteLine("");
            lineCount++;
        }

        Console.WriteLine($"You have listed {lineCount} items!");
        Thread.Sleep(8000);
    }
}