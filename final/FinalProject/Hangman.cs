using System;

class Hangman:Game
{
    public Hangman():base("Hangman"){}

    public override void InitializeGame()
    {
        List<string> hangmanWords = new List<string>();
        hangmanWords.Add("corn");
        hangmanWords.Add("pear");
        hangmanWords.Add("kiwi");
        hangmanWords.Add("plum");
        hangmanWords.Add("beef");
        hangmanWords.Add("cake");
        hangmanWords.Add("bean");
        hangmanWords.Add("pork");
        
        Random food = new Random();
        int randomFoodIndex = food.Next(hangmanWords.Count);
        randomWordFromList = hangmanWords[randomFoodIndex];
    }
    public override void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the hangman game!");
    }
    public override void Description()
    {
        Console.WriteLine("\nI am thinking of a 4 letter food. You have 6 guesses to help "
        + "you figure out what food I am thinking of. You are allowed to guess 1 letter per guess.");
        Console.Write("\nPress any key when are ready to play. ");
        Console.ReadKey();
        Console.Clear();
    }
    private static void DrawHangman(int wrong)
    {
        if (wrong == 0)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("    ===");
        }
        if (wrong == 1)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("     |");
            Console.WriteLine("     |");
            Console.WriteLine("    ===");
        }
        if (wrong == 2)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine(" |   |");
            Console.WriteLine("     |");
            Console.WriteLine("    ===");
        }
        if (wrong == 3)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|   |");
            Console.WriteLine("     |");
            Console.WriteLine("    ===");
        }
        if (wrong == 4)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("     |");
            Console.WriteLine("    ===");
        }
        if (wrong == 5)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/    |");
            Console.WriteLine("    ===");
        }
        if (wrong == 6)
        {
            Console.WriteLine("\n +---+");
            Console.WriteLine(" O   |");
            Console.WriteLine("/|\\  |");
            Console.WriteLine("/ \\  |");
            Console.WriteLine("    ===");
        }
    }
    private static int PrintWord(List<char>guessedLetters, String randomWordFromList)
    {
        int counter = 0;
        int rightLetters = 0;
        Console.Write("\r\n");
        foreach (char c in randomWordFromList)
        {
            if (guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters ++;
            }
            else
            {
                Console.WriteLine(" ");
            }
            counter ++;
        }
        return rightLetters;
    }
    private static void PrintLines(string randomWordFromList)
    {
        Console.Write("\r");
        foreach (char c in randomWordFromList)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("\u0305 ");
        }
    }
    public override void RunGame()
    {
        foreach (char c in randomWordFromList)
        {
            Console.Write("_ ");
        }

        int lengthOfRandomWord = randomWordFromList.Length;
        int wrongGuesses = 0;
        List<char> lettersGuessed = new List<char>();
        int lettersGuessedRight = 0;

        while (wrongGuesses != 6 && lettersGuessedRight != lengthOfRandomWord)
        {
            Console.Write("\nLetters guessed so far: ");

            foreach (char letter in lettersGuessed)
            {
                Console.Write(letter + " ");
            }

            Console.Write("\nGuess a letter: ");
            char letterGuessed = Console.ReadLine()[0];

            if (lettersGuessed.Contains(letterGuessed))
            {
                Console.WriteLine("\nYou have already guess this letter.");
                DrawHangman(wrongGuesses);
                lettersGuessedRight = PrintWord(lettersGuessed, randomWordFromList);
                PrintLines(randomWordFromList);
            }
            else
            {
                bool right = false;

                for (int i = 0; i < randomWordFromList.Length; i++)
                {
                    if (letterGuessed == randomWordFromList[i])
                    {
                        right = true;
                    }
                }
                if (right)
                {
                    DrawHangman(wrongGuesses);
                    lettersGuessed.Add(letterGuessed);
                    lettersGuessedRight = PrintWord(lettersGuessed, randomWordFromList);
                    Console.Write("\r\n");
                    PrintLines(randomWordFromList);
                }
                else
                {
                    wrongGuesses += 1;
                    lettersGuessed.Add(letterGuessed);
                    DrawHangman(wrongGuesses);
                    lettersGuessedRight = PrintWord(lettersGuessed, randomWordFromList);
                    Console.Write("\r\n");
                    PrintLines(randomWordFromList);
                }
            }
        }
        Console.WriteLine("\rGame is over! Thank you for playing!");
    }
}