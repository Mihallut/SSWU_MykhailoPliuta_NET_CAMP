using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Fence
    {
        public Tree Start { get; set; }
        public Tree End { get; set; }
        public double Length { get; set; }

        public Fence(Tree start, Tree end)
        {
            Start = start;
            End = end;
            CalculateLength();
        }

        private void CalculateLength()
        {
            Length = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
        }
    }
}
