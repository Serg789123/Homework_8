// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr1 = new int[3, 2];

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        arr1[i, j] = new Random().Next(0, 10);
    }
}

Console.WriteLine($"Задана матрица 1:");
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        Console.Write($"{arr1[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] arr2 = new int[2, 3];

for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        arr2[i, j] = new Random().Next(0, 10);
    }
}

Console.WriteLine($"Задана матрица 2:");
for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        Console.Write($"{arr2[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] prodMatr = new int[arr1.GetLength(0), arr2.GetLength(1)];

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        prodMatr[i, j] = 0;
        for (int k = 0; k < arr1.GetLength(1); k++)
        {
            prodMatr[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}

Console.WriteLine($"product of matrices:");
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        Console.Write($"{prodMatr[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
