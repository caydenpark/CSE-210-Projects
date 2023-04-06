using System;

public class GameFactory
{
    public Game CreateGame(string gameNumber)
        {
            Game game = new Game("");

            if (gameNumber == "1")
                game = new Hangman();
            else if(gameNumber == "2")
                game = new Wordle();
            else if(gameNumber == "3")
                game = new Riddle();
            return game;
        }
}