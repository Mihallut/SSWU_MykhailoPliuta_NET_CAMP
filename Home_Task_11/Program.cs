using System.Collections;
using Home_Task_11.Task_1;

namespace Home_Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 4, 6, 0, 1, 3, 9, 4, 7, 3, 7, 5, 2, 3 };
            int[] array2 = new int[] { 2, 4, 6, 0, 1, 3, 9, 4, 7, 3, 7, 5, 2, 3 };
            int[] array3 = new int[] { 2, 4, 6, 0, 1, 3, 9, 4, 7, 3, 7, 5, 2, 3 };

            QuickSort<int>.Sort(array1, PivotTypes.First);
            View<int>.PrintArr(array1);

            QuickSort<int>.Sort(array2, PivotTypes.Random);
            View<int>.PrintArr(array2);

            QuickSort<int>.Sort(array3, PivotTypes.Median);
            View<int>.PrintArr(array3);

        }
    }
}