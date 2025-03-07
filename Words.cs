using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WordSearch
{
    internal class Words
    {
        public Words() 
        {
            Random rnd = new Random();
            
            Dictionary<string, List<string>> wordCategories = new Dictionary<string, List<string>>();

            wordCategories.Add("Dogs", new List<string> { "Words.txt" });//pulls words from the text file

            List<string> categories = wordCategories.Keys.ToList();
            string randomCategory = categories[rnd.Next(0, categories.Count)];
            List<string> words = wordCategories[randomCategory];
            List<string> selectedWord = new List<string>();

            for (int i = 0; i < 8; i++)//takes the words variable and chooses a random word while checking for duplicates
            {
                string randomWord = words[rnd.Next(0, words.Count)];
                if (!randomWord.Contains(randomWord))
                {
                    selectedWord.Add(randomWord);
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
