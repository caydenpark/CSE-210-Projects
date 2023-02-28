
using System;

namespace ScriptureMemorizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            Console.WriteLine("Welcome to the Scripture Memorizer\n");
            Console.WriteLine("Choose a random verse (1) or use your own (2)? ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                book.ChooseScripture();
            }
            else
            {
                book.InputNewScripture();
            }

            Scripture scripture = new Scripture(book.GetScripture());

            scripture.DisplayScripture();
            Console.WriteLine("Press enter to hide words, or 'quit' to exit.");
            input = Console.ReadLine();
            while (input != "quit")
            {
                Console.Clear();
                scripture.HideWords();
                scripture.DisplayScripture();

                Console.WriteLine("Press enter to hide words, or 'quit' to exit.");
                input = Console.ReadLine();
            }
        }
    }
}