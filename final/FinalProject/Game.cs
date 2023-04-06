using System;

public class Game
{
    public string gameName;
    public string randomWordFromList = "Random";
    public char[]letters = new char[0];
    public string guess = "Guess";
    public char[]lettersInGuess = new char[0];

    public Game(string name)
    {
        gameName = name;
    }
    public virtual void InitializeGame()
    {
        List<string> listOfWords = new List<string>();
        letters = randomWordFromList.ToCharArray();
        lettersInGuess = guess.ToCharArray();
    }
    public virtual void StartMessage(){}
    public virtual void Description(){}
    public virtual void RunGame(){}
    
    public void ReturnToMain()
    {
        Console.Write("\nPress any key to return to the menu. ");
        Console.ReadKey();
    }
}  