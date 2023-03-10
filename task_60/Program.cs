// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] arr = new int[4, 4, 4];

IEnumerator<int> randoms = Enumerable.Range(10, arr.Length + 10).GetEnumerator();
randoms.MoveNext();

for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        for (int k = 0; k < arr.GetLength(2); k++, randoms.MoveNext())
            arr[i, j, k] = randoms.Current;

Console.WriteLine();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write($"{arr[i, j, k]} {(i, j, k)}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

