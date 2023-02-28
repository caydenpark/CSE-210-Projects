using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _word;
        private string _hiddenWord = "";
        private bool _isHidden = false;

        public Word(string word) 
        {
            _word = word;

            CreateHiddenWord();
        }

        private void CreateHiddenWord()
        {
            foreach (char letter in _word)
            {
                if (letter != '.' || letter != '!' || letter != '?' || 
                    letter != ',' || letter != ':' || letter != ';')
                {
                    _hiddenWord += "_";
                }
                else
                {
                    _hiddenWord += letter;
                }
            }
        }

        public void DisplayWord()
        {
            if (_isHidden)
            {
                Console.Write(_hiddenWord);
            }
            else
            {
                Console.Write(_word);
            }
        }

        public void HideWord()
        {
            _isHidden = true;
        }

        public void ShowWord()
        {
            _isHidden = false;
        }
    }
}