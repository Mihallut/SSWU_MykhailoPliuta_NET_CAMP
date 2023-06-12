using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Home_Task_11.Task_1
{
    public static class View<T>
    {
        public static void PrintArr(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
