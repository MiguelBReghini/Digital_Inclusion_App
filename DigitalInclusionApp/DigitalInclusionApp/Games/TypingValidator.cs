using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalInclusionApp.Games
{
    internal class TypingValidator
    {

        string targetWord = "";
        int progressIndex = 0;
        public bool IsComplete => progressIndex == targetWord.Length;
        public int ProgressIndex => progressIndex;

        public void StartWord(string word)
        {
            targetWord = word;
            progressIndex = 0;

        }
        public bool ValidateChar(char typed)
        {
            if (IsComplete)
            {
                return false;
            }
            if (typed == targetWord[progressIndex])
            {
                progressIndex++;
                    return true;
            }
            return false;
        }


        

    }
}
