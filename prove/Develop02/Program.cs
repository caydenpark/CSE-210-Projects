using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        //Start of the loop.
        int intAnswer = 0;
        while (intAnswer < 5)
        {
            //Display the menu for the user.
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //Prompt the user for input.
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            intAnswer = int.Parse(answer);

            //Show the user a random prompt from a list of prompts.
            List<string> prompts = new List<string> {"What was the best part of your day? ", "What was the weirdest part of your day? ", "Which side of the bed did you wake up on today? ", "Did you have any regrets today? ", "Would you call today a good day? "};
            Random random = new Random();
            int randomIndex = random.Next(prompts.Count);
            //convert int to string for the loop to work better.
            string randomPrompt = prompts[randomIndex];
        
            //Entry Entry = new Entry();

            //1. Write
            if (intAnswer == 1)
            {
                Console.Write(randomPrompt);
                string entry = Console.ReadLine();
                
            }
            //2. Display
            if (intAnswer == 2)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Console.WriteLine($"Date: {dateText} - Prompt: {randomPrompt} ");
            }
            //3. Load
            if (intAnswer == 3)
            {

            }
            //4. Save
            if (intAnswer == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
            }
            //5. Quit
        }
    }
}