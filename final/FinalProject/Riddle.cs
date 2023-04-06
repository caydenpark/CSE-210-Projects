using System;

public class Riddle:Game
{
    public Riddle():base("Riddle"){}
    public string randomRiddle;

    public override void InitializeGame()
    {
        Dictionary<string, string> riddlesDictionary = new Dictionary<string, string>();
        riddlesDictionary.Add("Nothing", "The poor have me; the rich need me. Eat me and you will die. What am I? ");
        riddlesDictionary.Add("Bank", "I have branches but no fruit, trunk, or leaves. What am I? ");
        riddlesDictionary.Add("Alphabet", "What word contains all of the twenty-six letters? ");
        riddlesDictionary.Add("Swims", "What word can be read the same upside down or right side up? ");
        riddlesDictionary.Add("Incorrectly", "Which word in the dictionary is spelled incorrectly? ");

        Random riddle = new Random();
        int randomRiddleIndex = riddle.Next(riddlesDictionary.Count);
        var element = riddlesDictionary.ElementAt(randomRiddleIndex);
        randomRiddle = element.Value;
        randomWordFromList = element.Key;
    }
    public override void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("I hope you're good at riddles!");
    }
    public override void Description()
    {
        Console.WriteLine("\nIn this game, you will be prompted a riddle."
        + " It is up to you to solve it with a one word answer.");
        Console.Write("\nPress enter when are ready to play. ");
        Console.ReadKey();
    }
    public override void RunGame()
    {
        while (guess.ToUpper() != randomWordFromList.ToUpper())
        {
            Console.Clear();
            Console.Write(randomRiddle);
            guess = Console.ReadLine();
            if (guess.ToUpper() == randomWordFromList.ToUpper())
            {
                Console.WriteLine("\nNice, you got it!");
                break;
            }
            else if (guess.ToUpper() != randomWordFromList.ToUpper())
            {
                Console.WriteLine("Sorry, that's wrong! Try again!" );
            }
        }
    }
}