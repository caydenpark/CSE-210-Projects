using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private string _reference = "";
        private string _text = "";
        private List<Verse> verses = new List<Verse>();
        
        public Scripture(string scripture)
        {
            string[] scriptureArray = scripture.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            _reference = scriptureArray[0];
            _text = scriptureArray[1];
            CreateVerses();
        }

        public void DisplayScripture()
        {
            Console.WriteLine($"\n{_reference}");
            foreach (Verse verse in verses)
            {
                verse.DisplayVerse();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void CreateVerses()
        {
            string[] splitVerses = 
                _text.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            foreach (string verse in splitVerses)
            {
                Verse newVerse = new Verse(verse);
                verses.Add(newVerse);
            }
        }

        public void HideWords()
        {
            foreach (Verse verse in verses)
            {
                verse.HideWords();
            }
        }
    }
}