using System;

namespace Transliterator
{
    public class Parser
    {
        public void LoadText(string text)
        {
            this.text = text;
            currentPosition = 0;
            totalLength = text.Length;
        }

        public char ShowNextChar()
        {
            return text[currentPosition + 1];
        }

        public char ShowCurrentChar()
        {
            return text[currentPosition];
        }

        public void GoForward()
        {
            if (HasNext())
            {
                ++currentPosition;
            }
            else
            {
                throw new Exception("Has no next char");
            }
        }

        public bool HasNext()
        {
            return currentPosition + 1 < totalLength;
        }

        private string text;
        private int currentPosition;
        private int totalLength;
    }
}