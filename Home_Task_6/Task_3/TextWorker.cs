using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{// сумарний бал 92
    
    public static class TextWorker
    {

        public static List<string> GetUniqueWords(string text)
        {
            return ProcessText(text).ToList();
        }
        private static IEnumerable<string> ProcessText(string text)
        {
            string[] words = text.Split(new[] { ' ', '.', ',', ';', ':', '!', '?', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in words)
            {
                if (IsUniqueWord(word, words))
                {
                    yield return word;
                }
            }
        }
        private static bool IsUniqueWord(string word, string[] words)
        {// можна перервати цикл при cont=1.також можна було скористатись стандартним методом Count()
            int count = 0;
            foreach (string w in words)
            {
                if (w.ToLower() == word.ToLower())
                {
                    count++;
                }
            }
            return count == 1;
        }
    }
}
