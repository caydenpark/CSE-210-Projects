using System;

class Program
{
    static void Main(string[] args)
    {
        string gameNumber = " ";
        while (gameNumber != "4")
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            gameNumber = Console.ReadLine();
            GameFactory factory = new GameFactory();
            Game game = factory.CreateGame(gameNumber);

        }
    }
}