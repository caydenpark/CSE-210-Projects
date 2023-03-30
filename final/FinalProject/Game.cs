using System;

public class Game
{
    public string gameName;
    public Game(string name)
    {
        gameName = name;
    }
    public virtual void Description()
    {
        Console.WriteLine("");
    }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {gameName}!\n");
    }
    public virtual void InitializeGame(){}
    
    public virtual void Run(){}

}