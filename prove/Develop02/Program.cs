using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        //Start of the loop.
        int intAnswer = 0;
        while (intAnswer < 5)
        {
            //Display the menu for the user.
            menu.DisplayMenu();

            //Prompt the user for input.
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            intAnswer = int.Parse(answer);

            //1. Write
            if (intAnswer == 1)
            {
                //Show the user a random prompt from a list of prompts.
                Entry entry = new Entry();
                Console.Write(entry.prompt);
                entry.text = Console.ReadLine();
                entry.date = DateTime.Now.ToShortDateString();
                journal.entriesList.Add(entry);
            }
            //2. Display
            if (intAnswer == 2)
            {
                foreach(Entry entry in journal.entriesList)
                {
                    entry.DisplayEntry();
                }
            }
            //3. Load
            if (intAnswer == 3)
            {
                journal.Load();
            }
            //4. Save
            if (intAnswer == 4)
            {
                journal.Save();
            }
            //5. Quit
        }
    }
}