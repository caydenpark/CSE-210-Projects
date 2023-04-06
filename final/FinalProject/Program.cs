using System;

class Program
{
    static void Main(string[] args)
    {
        string gameNumber = " ";
        while (gameNumber != "4")
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.DisplayMenu();
            gameNumber = Console.ReadLine();
            GameFactory factory = new GameFactory();
            Game game = factory.CreateGame(gameNumber);

            game.InitializeGame();
            game.StartMessage();
            game.Description();
            game.RunGame();
            
            if (gameNumber != "4")
            {
                game.ReturnToMain();
            }
        }
    }
}