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

int[,] randomArr = new int[rnd.Next(10), rnd.Next(10)];

for (var i = 0; i < randomArr.GetUpperBound(0) + 1; i++)
{
    for (var j = 0; j < randomArr.GetUpperBound(1) + 1; j++)
    {
        randomArr[i, j] = rnd.Next(20);
        Console.Write(randomArr[i, j] + " ");
    }
    Console.WriteLine();
}

double[] resultsArr = new double[randomArr.GetUpperBound(1) + 1];

for (var j = 0; j < randomArr.GetUpperBound(1) + 1; j++)
{
    resultsArr[j] = 0;
    for (var i = 0; i < randomArr.GetUpperBound(0) + 1; i++)
    {
        resultsArr[j] += randomArr[i, j];
    }
    resultsArr[j] /= randomArr.GetUpperBound(0) + 1;
}

for (var i = 0; i < resultsArr.Length; i++)
{
    Console.Write(Math.Round(resultsArr[i], 2) + " ");
}
