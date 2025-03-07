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

            //string linesFilePath = "Words.txt";
            
            Dictionary<string, List<string>> wordCategories = new Dictionary<string, List<string>>();

            wordCategories.Add("Dogs", new List<string> { "Words.txt" });

            List<string> categories = wordCategories.Keys.ToList();
            string randomCategory = categories[rnd.Next(0, categories.Count)];
            List<string> words = wordCategories[randomCategory];
            List<string> selectedWord = new List<string>();

            for (int i = 0; i < 8; i++)
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

        public static void ReadFromFile()
        {
            string linesFilePath = "Words.txt";
            string[] linesRead = File.ReadAllLines(linesFilePath);
            Console.WriteLine(linesRead);
        }
    }
}
