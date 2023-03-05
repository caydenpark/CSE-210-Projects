using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

class Breather : Activity
{
    public Breather():base("Breathing")
    {

    }
    public override void Description()
    {
        Console.WriteLine("This activity will help you relax by "
        +"walking your through breathing in and out slowly. Clear "
        +"your mind and focus on your breathing.\n");
    }
    public override void ActualActivities()
    {
        // Breathe in... / Breathe out...
        List<string> animationCountdown = new List<string>();
        animationCountdown.Add("4");
        animationCountdown.Add("3");
        animationCountdown.Add("2");
        animationCountdown.Add("1");
        animationCountdown.Add("0");

        int i = 0;
        int durationInt;
        durationInt = int.Parse(duration);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.Seconds <= durationInt)
        {
            string countDown = animationCountdown[i];

            Console.WriteLine("Breathe in...");
            Console.Write(countDown);
            Thread.Sleep(1500);
            Console.WriteLine("\b \b");
            Console.WriteLine("Breathe out...");
            
            i++;
            
        }
    }
}