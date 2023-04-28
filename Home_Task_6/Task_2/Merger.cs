using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class Merger
    {
        public static int[] Merge(params int[][] nums)
        {
            return GetSortedArray(nums).ToArray();
        }

        private static IEnumerable<int> GetSortedArray(params int[][] arrays)
        {
            var mergedArray = arrays.SelectMany(x => x).OrderBy(x => x);
            foreach (int item in mergedArray)
            {
                yield return item;
            }
        }
    }
}
