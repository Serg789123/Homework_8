// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = new int[4, 5];

FillArray(arr);
Console.WriteLine($"Задан массив:");
PrintArray(arr);

int temp;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int max = j;
        for (int k = j + 1; k < arr.GetLength(1); k++)
        {
            if (arr[i, k] > arr[i, max])
            {
                max = k;
            }
        }
        temp = arr[i, max];
        arr[i, max] = arr[i, j];
        arr[i, j] = temp;
    }
}

Console.WriteLine($"Упорядоченный массив:");
PrintArray(arr);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
