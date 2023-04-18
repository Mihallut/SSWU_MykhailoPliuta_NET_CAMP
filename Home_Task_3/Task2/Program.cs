namespace Task2
{
    internal class Program
    {// У діаграмі не правильно визначені взаємозв'язки між класами. Не видно, де створюються об'єкти класів та як вони взаємодіють.
        static void Main(string[] args)
        {
            string initialText1 = "word word";
            int? index = TextWorker.FindSecondEntranceIndex(initialText1, "word");
            Console.WriteLine(index);

            string initialText2 = "word Word word word Word";
            int count = TextWorker.CapitalizedCount(initialText2);
            Console.WriteLine(count);

            string initialText3 = "word Worrd wword wordd Word";
            string result = TextWorker.ReplaceWordsWithDoubling(initialText3, "WORD");
            Console.WriteLine(result);
        }
    }
}
