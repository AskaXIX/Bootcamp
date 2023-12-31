﻿int n = Convert.ToInt32(System.Console.ReadLine());
int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for(int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    System.Console.WriteLine();
}
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    System.Console.WriteLine();
}
// 0(n^2 / 2)