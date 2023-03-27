int size = 30;
int[,] matrix = new int[size, size];

Random rand = new Random();
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = rand.Next(0, 16);
    }
}

int maxLength = 0;
int startRow = -1;
int startCol = -1;
int endRow = -1;
int endCol = -1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int currentLength = 1;
    int currentStartCol = 0;

    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == matrix[i, j - 1])
        {
            currentLength++;
        }
        else
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startRow = i;
                startCol = currentStartCol;
                endRow = i;
                endCol = j - 1;
            }

            currentLength = 1;
            currentStartCol = j;
        }
    }

    if (currentLength > maxLength)
    {
        maxLength = currentLength;
        startRow = i;
        startCol = currentStartCol;
        endRow = i;
        endCol = matrix.GetLength(1) - 1;
    }
}

if (maxLength > 0)
{
    Console.WriteLine("Color: " + matrix[startRow, startCol] + " | Start: (" + startRow + ", " + startCol + ") | End: (" + endRow + ", " + endCol + ") | Length: " + maxLength);
}
else
{
    Console.WriteLine("No horizontal lines found.");
}


for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (matrix[i, j] < 10)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), matrix[i, j].ToString());
            Console.Write(matrix[i, j] + "  ");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), matrix[i, j].ToString());
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
    }
    Console.WriteLine();
}