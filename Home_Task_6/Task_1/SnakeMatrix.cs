using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class SnakeMatrix : IEnumerable
    {
        private int[,] _matrix;

        public SnakeMatrix(int[,] matrix)
        {
            _matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Array.Copy(matrix, _matrix, matrix.Length);
            // точно лишнє
            Console.WriteLine();
        }

        public IEnumerator<int> GetEnumerator()
        {// перевірте для парної і непарної розмірності матриці.
            int rowCount = _matrix.GetLength(0);
            int colCount = _matrix.GetLength(1);
            for (int i = 0; i < rowCount + colCount - 1; i++)
            {
                if (i % 2 != 0)
                {
                    for (int row = Math.Min(i, rowCount - 1), col = i - row; row >= 0 && col < colCount; row--, col++)
                    {
                        yield return _matrix[row, col];
                    }
                }
                else
                {
                    for (int col = Math.Min(i, colCount - 1), row = i - col; col >= 0 && row < rowCount; col--, row++)
                    {
                        yield return _matrix[row, col];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
