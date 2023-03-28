//Вітаю. Перше завдання по створенню репозиторію Ви виконали.
Console.WriteLine("Enter row count:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter col count:");
int n = int.Parse(Console.ReadLine());

int counter1 = 1;
int[,] matrix1 = new int[m, n];
for (int i = 0; i < m; i++)
{
    matrix1[i, 0] = counter1;
    counter1++;
}
for (int i = 1; i < n; i++)
{
    matrix1[m - 1, i] = counter1;
    counter1++;
}
for (int i = m - 2; i >= 0; i--)
{
    matrix1[i, n - 1] = counter1;
    counter1++;
}
for (int i = n - 2; i >= 1; i--)
{
    matrix1[0, i] = counter1;
    counter1++;
}
int c = 1;
int d = 1;

while (counter1 < m * n)
{

    while (matrix1[c + 1, d] == 0)
    {
        matrix1[c, d] = counter1;
        counter1++;
        c++;
    }

    while (matrix1[c, d + 1] == 0)
    {
        matrix1[c, d] = counter1;
        counter1++;
        d++;
    }

    while (matrix1[c - 1, d] == 0)
    {
        matrix1[c, d] = counter1;
        counter1++;
        c--;
    }

    while (matrix1[c, d - 1] == 0)
    {
        matrix1[c, d] = counter1;
        counter1++;
        d--;
    }

}

//При данном решении в центре всегда остаётся незаполненная ячейка.
//Убираем её при помощи следующего цикла.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix1[i, j] == 0)
        {
            matrix1[i, j] = counter1;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix1[i, j] < 10)
        {
            Console.Write(matrix1[i, j] + "  ");
        }
        else
        {
            Console.Write(matrix1[i, j] + " ");
        }
    }
    Console.WriteLine();
}


//test
