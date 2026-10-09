using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DigitalInclusionApp.Games
{
    internal class WordList
    {
        public List<string> words { get; set; }
    }
    internal class WordRandomizer
    {
        
        string currentWord = "";
        int LastIndex;
        List<string> words;
        string wordCapitalized = "";
        Random Randomizer = new Random();

        public string RandomWord
        {
            get { return wordCapitalized;}
            
              
        }
     
        public WordRandomizer()
        {
            string textJson = Properties.Resources.portuguese;
            WordList dados = JsonSerializer.Deserialize<WordList>(textJson);
            words = dados.words;
        }

        public void RandomizeIndex()
        {
            int currentIndex;
            do
            {
                currentIndex = Randomizer.Next(words.Count);
                
                

            } while (LastIndex == currentIndex);
            LastIndex = currentIndex;
            currentWord = words[currentIndex];
            wordCapitalized = char.ToUpper(currentWord[0]) + currentWord.Substring(1);
        }
       





    }
}
