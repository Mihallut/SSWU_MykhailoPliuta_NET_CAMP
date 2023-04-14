using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2
{
    public static class EmailAndLexemesFinder
    {
        private static string _emailPattern = "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";
        private static string _lexemePattern = @"(?<!\S)@\w+(?!\w+@\w+\.\w+)";

        public static List<string> FindAll(string text)
        {
            List<string> result = new List<string>();

            MatchCollection emails = Regex.Matches(text, _emailPattern);

            foreach (Match email in emails)
            {
                result.Add(email.Value);
            }
            MatchCollection lexemes = Regex.Matches(text, _lexemePattern);

            foreach (Match lexeme in lexemes)
            {
                result.Add(lexeme.Value);
            }

            return result;
        }
    }
}
