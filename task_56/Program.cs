// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

int[,] arr = new int[4, 3];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
    }
}

Console.WriteLine($"Задан массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int sum = 0;

int[] array = new int[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    array[i] = sum;
    sum = 0;
}

Console.WriteLine($"Создан массив сумм строк:");
Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write("\b\b ");
Console.WriteLine("]");
Console.WriteLine();

int minArray = array[0];
int result = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < minArray)
    {
        minArray = array[i];
    }
    if (array[i] == minArray)
    {
        result = i;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result + 1}");
Console.WriteLine();
