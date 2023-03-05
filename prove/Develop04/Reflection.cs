using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

class Reflection : Activity
{
    public Reflection():base("Reflecting")
    {
        
    }
    public override void Description()
    {
        Console.WriteLine("This activity will help you reflect on "
        +"times in your life when you have shown strength and resilience. "
        +"This will help you recognize the power you have and how you can "
        +"use it in other aspects of your life.\n");
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

        Console.WriteLine("Consider the following propmt:");
        Console.WriteLine($"--- {randomPrompt} ---");

        List<string> questions = new List<string>();
        prompts.Add("Why was this experience meaningful to you?");
        prompts.Add("Have you ever done anything like this before?");
        prompts.Add("How did you get started?");
        prompts.Add("How did you feel when it was complete?");
        prompts.Add("What made this time different than other times when you were not as successful?");
        prompts.Add("What is your favorite thing about this experience?");
        prompts.Add("What could you learn from this experience that applies to other situations?");
        prompts.Add("What did you learn about yourself through this experience?");
        prompts.Add("How can you keep this experience in mind in the future?");

        Random randomQ = new Random();
        int randomIndexQ = randomQ.Next(questions.Count);
        string randomQuestion = questions[randomIndexQ];

        int durationInt;
        durationInt = int.Parse(duration);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.Seconds <= durationInt)
        {
            Thread.Sleep(5000);
            Console.Write(randomQuestion);
            Pause();
        }
    }
}