using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    static internal class TextWorker
    {
        public static int? FindSecondEntranceIndex(string text, string soughtFor)
        {
            // Ця умова є вже в Contains))
            if (text.Length > soughtFor.Length)
            {
                if (text.Contains(soughtFor))
                {
                    int firstIndex = text.IndexOf(soughtFor);
                    if (firstIndex == -1)
                    {
                        return null;
                    }
                    int secondIndex = text.IndexOf(soughtFor, firstIndex + soughtFor.Length);
                    if (secondIndex == -1)
                    {
                        return null;
                    }
                    return secondIndex;
                }
            }
            return null;
        }

        public static int CapitalizedCount(string text)
        {

            int count = 0;
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i][0]))
                {
                    count++;
                }
            }

            return count;
        }


        public static string ReplaceWordsWithDoubling(string text, string substitute)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (ContainDouble(words[i]))
                {
                    words[i] = substitute;
                }
            }
            //Втрачено початкові пробільні символи. 
            string result = String.Join(' ', words);

            return result;
        }

        private static bool ContainDouble(string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
