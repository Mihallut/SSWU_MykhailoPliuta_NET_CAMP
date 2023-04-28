namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 1, 3 };
            int[] arr2 = { 8, 2, 3, 4 };

            int[] result = Merger.Merge(arr1, arr2);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}