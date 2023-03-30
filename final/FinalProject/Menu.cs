using System;

class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nSelect the game you would like to play:");
        Console.WriteLine("    1. Hangman");
        Console.WriteLine("    2. Wordle");
        Console.WriteLine("    3. Spelling Bee");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu(1, 2, 3, or 4): ");
    }
}