namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "word word1 word2 word1 word2 word3";
            List<string> uniqueWords = TextWorker.GetUniqueWords(text);

            foreach (string word in uniqueWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}