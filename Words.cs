using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    internal class Words
    {
        /*/public Words() 
        {
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] words = { "Cat", "Dog", "Owl", "Ferret", "Dove", "Sparrow", "Whale", };
            string[] arrayIndex8 = new string[8];
            Random rnd = new Random();

            for (int i = 0; i < arrayIndex8.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);
                string potentialWord = words[randomIndex];
                if (arrayIndex8.Contains(potentialWord))
                {
                    i--;
                    continue;
                }
                arrayIndex8[i] = potentialWord;
            }

        }/*/

        public static void ReadFromFile()
        {
            string linesFilePath = "Words.txt";
            string[] linesRead = File.ReadAllLines(linesFilePath);
            Console.WriteLine(linesRead);
        }
    }
}
