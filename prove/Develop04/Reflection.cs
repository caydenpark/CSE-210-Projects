using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Linq;

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

        Console.WriteLine("\nConsider the following propmt:");
        Console.WriteLine($"\n--- {randomPrompt} ---");
        Console.Write("\nPress enter to continue.");
        Console.ReadLine();
        Console.Clear();

        List<string> questions = new List<string>();
        questions.Add("> Why was this experience meaningful to you?");
        questions.Add("> Have you ever done anything like this before?");
        questions.Add("> How did you get started?");
        questions.Add("> How did you feel when it was complete?");
        questions.Add("> What made this time different than other times when you were not as successful?");
        questions.Add("> What is your favorite thing about this experience?");
        questions.Add("> What could you learn from this experience that applies to other situations?");
        questions.Add("> What did you learn about yourself through this experience?");
        questions.Add("> How can you keep this experience in mind in the future?");
        
        string randomQuestion = "";

        Random randomQ = new Random();
        int randomIndexQ = randomQ.Next(questions.Count);
        randomQuestion = questions[randomIndexQ];

        int durationInt;
        durationInt = int.Parse(duration);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.Seconds <= durationInt)
        {
            foreach (var question in questions.ToList())
            {
                //questionIndex = questions[0];
                Thread.Sleep(2000);
                Console.Write($"\n{question}");
                Pause();
                questions.Remove(question);
            }
        }
    }
}