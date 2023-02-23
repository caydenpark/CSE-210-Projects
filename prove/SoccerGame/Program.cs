using System;
using System.Numerics;

public class Program
{
    private static Ball _ball;
    private static Player _player1;
    private static Player _player2;

    public static void Main(string[] args)
    {
        // create participants
        Vector2 position1 = new Vector2(0, 0);
        Vector2 position2 = new Vector2(20, 100);

        _ball = new Ball(position1);
        _player1 = new Player(position1);
        _player2 = new Player(position2);
        
        // start the game
        PrintStats();

        // play the game
        for (int i = 0; i < 60; i++)
        {
            MovePlayer1();
            PrintStats();
            MovePlayer2();
            PrintStats();
        }
    }

    private static void MovePlayer1()
    {
        Console.Write("Player 1: w, s, a, d, or p? ");
        string command = Console.ReadLine();

        Vector2 velocity = new Vector2(2, 2);

        if (command == "w")
        {
            velocity = new Vector2(0, 1);
            _player1.Move(velocity);
            _player1.Dribble(_ball);
        }
        else if (command == "s")
        {
            velocity = new Vector2(0, -1);
            _player1.Move(velocity);
            _player1.Dribble(_ball);
        }
        else if (command == "a")
        {
            velocity = new Vector2(-1, 0);
            _player1.Move(velocity);
            _player1.Dribble(_ball);
        }
        else if (command == "d")
        {
            velocity = new Vector2(1, 0);
            _player1.Move(velocity);
            _player1.Dribble(_ball);
        }
        else if (command == "p")
        {
            _player1.Pass(_ball, _player2);
        }
    }

    private static void MovePlayer2()
    {
        Console.Write("Player 2: i, k, l, r, or p? ");
        string command = Console.ReadLine();

        Vector2 velocity = new Vector2(2, 2);

        if (command == "i")
        {
            velocity = new Vector2(0, 1);
            _player2.Move(velocity);
        }
        else if (command == "k")
        {
            velocity = new Vector2(0, -1);
            _player2.Move(velocity);
        }
        else if (command == "j")
        {
            velocity = new Vector2(-1, 0);
            _player2.Move(velocity);
        }
        else if (command == "l")
        {
            velocity = new Vector2(1, 0);
            _player2.Move(velocity);
        }
        else if (command == "p")
        {
            _player2.Pass(_ball, _player1);
        }
    }

    private static void PrintStats()
    {
        Console.WriteLine("Moving...");
        Console.WriteLine($"Ball: {_ball.GetPosition()}");
        Console.WriteLine($"Player1: {_player1.GetPosition()}");
        Console.WriteLine($"Player2: {_player2.GetPosition()}");

        if (_player1.HasBall(_ball))
        {
            Console.WriteLine("\nPlayer 1 has the ball!\n");    
        }
        else if (_player2.HasBall(_ball))
        {
            Console.WriteLine("\nPlayer 2 has the ball!\n");    
        }
    }
}
