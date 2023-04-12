using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    public static class QuotesFinder
    {
        private static string _quotesPattern = @"[\(\)]";
        private static char[] _endOfSentenceSigns = new char[] { '.', '?', '!' };

        public static List<string> FindSentencesWithQuotes(List<string> text)
        {
            List<char> textAsCharList = new List<char>();
            List<string> sentences = new List<string>();

            List<string> result = new List<string>();

            ConvertTextToCharList(text, textAsCharList);
            SplitCharListToSentences(textAsCharList, sentences);

            foreach (string s in sentences)
            {
                if (Regex.IsMatch(s, _quotesPattern))
                {
                    result.Add(s);
                }
            }

            return result;
        }

        private static void ConvertTextToCharList(List<string> text, List<char> textAsCharList)
        {
            foreach (string s in text)
            {
                char[] chars = s.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    textAsCharList.Add(chars[i]);
                }
            }
        }

        private static void SplitCharListToSentences(List<char> textAsCharList, List<string> sentences)
        {
            for (int i = 0; i < textAsCharList.Count; i++)
            {
                if (char.IsUpper(textAsCharList[i]))
                {
                    List<char> sentenceAsCharList = new List<char>();
                    do
                    {
                        sentenceAsCharList.Add(textAsCharList[i]);
                        i++;
                    } while (!_endOfSentenceSigns.Contains(textAsCharList[i - 1]));
                    sentences.Add(new string(sentenceAsCharList.ToArray()));
                }
            }
        }
    }
}
