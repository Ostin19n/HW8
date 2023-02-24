// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = Start2Array(4, 3, 1, 10);

Show2Array(array);

Console.WriteLine();

int[] rowSum = FindSum(array);

int result = FindMinSumElemenets(rowSum);

Console.WriteLine($"Номер строки с наименьшей суммой элементов = {result}");




int[,] Start2Array(int rows, int columns, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] FindSum(int[,] array)
{
    int[] rowSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        rowSum[i] = sumRow;
    }
    return rowSum;
}

int FindMinSumElemenets(int[] arr)
{
    int min = arr[0];
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            result = i;
        }
    }
    return result = result + 1;
}