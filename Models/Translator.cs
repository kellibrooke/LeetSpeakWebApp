using System;
using System.Collections.Generic;

namespace LeetSpeak.Models
{
    public class Translator
    {
        private string _phrase;

        public Translator (string userPhrase)
        {
            _phrase = userPhrase;
        }

        public char CharacterSwap(char letter)
        {
            if (letter == 'e' || letter == 'E')
            {
                return '3';
            }
            else if (letter == 'o' || letter == 'O')
            {
                return '0';
            }
            else if (letter == 'I')
            {
                return '1';
            }
            else if (letter == 't' || letter == 'T')
            {
                return '7';
            }
            else if (letter == 's' || letter == 'S')
            {
                return 'z';
            }
            else
            {
                return letter;
            }
        }

        public void ArrayReplace()
        {
            char[] phraseArray = _phrase.ToCharArray();
            int start = 0;
            if (phraseArray[start] == 's' || phraseArray[start] == 'S')
            {
                start++;
            }
            for (int i = start; i < phraseArray.Length; i++ )
            {
                if ((phraseArray[i] == 's' || phraseArray[i] == 'S') && (phraseArray[i - 1] == ' ' || phraseArray[i - 1] == '\'' || phraseArray[i - 1] == '\"'))
                {
                    phraseArray[i] = phraseArray[i];
                }
                else
                {
                    phraseArray[i] = CharacterSwap(phraseArray[i]);
                }
            }
            string result = string.Join("", phraseArray);
            _phrase = result;
        }

        public string GetPhrase()
        {
            return _phrase;
        }
    }
}
