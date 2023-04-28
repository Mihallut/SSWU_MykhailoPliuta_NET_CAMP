namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            SnakeMatrix snakeMatrix = new SnakeMatrix(matrix);
            foreach (int i in snakeMatrix)
            {
                Console.Write(i + " ");
            }

        }
    }
}