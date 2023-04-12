using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Renderer
    {
        public static void RenderList<T>(List<T> values)
        {
            foreach (T value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
