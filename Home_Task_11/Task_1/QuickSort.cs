using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_11.Task_1
{
    internal static class QuickSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr, PivotTypes pivotType)
        {
            Sort(arr, 0, arr.Length - 1, pivotType);
        }
        private static void Sort(T[] arr, int left, int right, PivotTypes pivotType)
        {
            if (left < right)
            {
                int pivotIndex = -1;
                switch (pivotType)
                {
                    case PivotTypes.First:
                        pivotIndex = left;
                        break;
                    case PivotTypes.Random:
                        pivotIndex = new Random().Next(left, right + 1);
                        break;
                    case PivotTypes.Median:
                        pivotIndex = GetMedianIndex(arr, left, right);
                        break;
                }

                int pivotFinalIndex = Partition(arr, left, right, pivotIndex);

                Sort(arr, left, pivotFinalIndex - 1, pivotType);
                Sort(arr, pivotFinalIndex + 1, right, pivotType);
            }
        }

        private static int Partition(T[] arr, int left, int right, int pivotIndex)
        {
            T pivot = arr[pivotIndex];
            Swap(arr, pivotIndex, right);
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j].CompareTo(pivot) < 0)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }

            Swap(arr, i, right);
            return i;
        }

        private static int GetMedianIndex(T[] arr, int left, int right)
        {
            int median = (left + right) / 2;

            if (arr[left].CompareTo(arr[median]) <= 0)
            {
                if (arr[median].CompareTo(arr[right]) <= 0)
                    return median;
                else if (arr[left].CompareTo(arr[right]) <= 0)
                    return right;
                else
                    return left;
            }
            else
            {
                if (arr[left].CompareTo(arr[right]) <= 0)
                    return left;
                else if (arr[median].CompareTo(arr[right]) <= 0)
                    return right;
                else
                    return median;
            }
        }

        private static void Swap(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

