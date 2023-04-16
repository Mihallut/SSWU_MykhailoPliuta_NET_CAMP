using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Mik\\source\\repos\\111_Sigma\\HW\\Home_Task_4\\Task_2\\Text.txt";

            string text = TxtReader.ReadTextFromFile(path);

            List<string> matches = EmailAndLexemesFinder.FindAllWithoutRegex(text);

            foreach (string match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}