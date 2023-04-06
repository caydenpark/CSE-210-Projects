using System;

public class Wordle:Game
{
    public Wordle():base("Wordle"){}
    public override void InitializeGame()
    {
        List<string> wordleWords = new List<string>();
        wordleWords.Add("Dog");
        wordleWords.Add("Cat");
        wordleWords.Add("Pig");
        wordleWords.Add("Cow");
        wordleWords.Add("Bat");
        wordleWords.Add("Ant");
        wordleWords.Add("Bee");
        wordleWords.Add("Fox");

        Random animal = new Random();
        int randomAnimalIndex = animal.Next(wordleWords.Count);
        randomWordFromList = wordleWords[randomAnimalIndex];
    }
    public override void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Wordle Game!");
    }
    public override void Description()
    {
        Console.WriteLine("\nI am thinking of animal that has 3 letters in it..."
        +" If any of the letters you guessed exist in the word, I will tell you.");
        Console.Write("\nPress any key when are ready to play. ");
        Console.ReadKey();
    }
    public override void RunGame()
    {
        while (guess.ToUpper() != randomWordFromList.ToUpper())
        {
            Console.Clear();
            Console.Write("What animal are you thinking of? ");
            guess = Console.ReadLine();
            
            foreach (char letter in guess.ToUpper())
            {
                if (randomWordFromList.ToUpper().Contains(letter))
                {
                    Console.WriteLine($"The letter {letter} does exist in this word!");
                }
                else
                {
                    Console.WriteLine($"The letter {letter} does not exist in this word.");
                }
                Thread.Sleep(3500);
            }
            if (guess.ToUpper() != randomWordFromList.ToUpper())
            {   
                Console.Write("\nPress any key when are ready to guess again. ");
                Console.ReadKey();
            }
            if (guess.ToUpper() == randomWordFromList.ToUpper())
            {
                Console.WriteLine("\nNice, you got it!");
                break;
            }
        }
    }
}