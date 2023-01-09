using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (gradePercentage >= 60)
        {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class. Better luck next time.");
        }
    }
}