using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DigitalInclusionApp.Games
{
    internal class WordList
    {
        public List<string>? words { get; set; }
    }
    internal class WordRandomizer
    {

        string currentWord = "";
        int LastIndex;
        List<string> words = new();
        string wordCapitalized = "";
        Random Randomizer = new Random();

        public string RandomWord
        {
            get { return wordCapitalized;}


        }

        public WordRandomizer()
        {
            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var assemblyDir = Path.GetDirectoryName(assemblyLocation);

            if (assemblyDir != null)
            {
                var resourcePath = Path.Combine(assemblyDir, "Resources", "portuguese.json");

                string textJson = File.ReadAllText(resourcePath);
                WordList? dados = JsonSerializer.Deserialize<WordList>(textJson);
                if (dados?.words != null)
                {
                    words = dados.words;
                }
            }
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
