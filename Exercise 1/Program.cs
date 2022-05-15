using System;

double[,] Generate2Arr(int min = -50, int max = 50, 
    int m = 3, int n = 3)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];

    for(int i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            result[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return result;
}

Random rnd = new Random();

Console.Write("Количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArr = Generate2Arr(m:m, n:n);

for(int i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write(Math.Round(myArr[i, j], 2) + " ");
    }
        Console.WriteLine();
}