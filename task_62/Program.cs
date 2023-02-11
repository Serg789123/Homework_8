// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, m];

int n = 1;
int a = 0;
int b = 0;

while (n <= arr.GetLength(0) * arr.GetLength(1))
{
    arr[a, b] = n;
    n++;
    if (a <= b + 1 && a + b + 1 < arr.GetLength(1))
        b++;
    else if (a < b && a + b + 1 >= arr.GetLength(0))
        a++;
    else if (a >= b && a + b + 1 > arr.GetLength(1))
        b--;
    else
        a--;
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($" {arr[i, j],2}");
    }
    Console.WriteLine();
}
