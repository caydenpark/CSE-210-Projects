using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Verse
    {
        private string _verse;
        private List<Word> _words = new List<Word>();
        private List<int> _hiddenIndexes = new List<int>();

        public Verse(string verse) 
        {
            _verse = verse;
            CreateWords();
        }

        private void CreateWords()
        {
            string[] splitWords = 
                _verse.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in splitWords)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
            }
        }

        public void DisplayVerse()
        {
            foreach (Word word in _words)
            {
                word.DisplayWord();
                Console.Write(" ");
            }
        }

        private int GetRandomIndex(int maximum)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, maximum);
            while (_hiddenIndexes.Contains(randomIndex))
            {
                randomIndex = random.Next(0, maximum);
            }
            _hiddenIndexes.Add(randomIndex);

            return randomIndex;
        }

        public void HideWords()
        {
            int numToHide = 3;
            
            if (_words.Count == _hiddenIndexes.Count)
            {
                return;
            }
            else if (_words.Count - 3 <= _hiddenIndexes.Count)
            {
                numToHide = _words.Count - _hiddenIndexes.Count;
            }
            
            for (int i = 0; i < numToHide; i++)
            {
                _words[GetRandomIndex(_words.Count)].HideWord();
            }
        }
    }
}