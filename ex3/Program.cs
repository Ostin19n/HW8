// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = Start2Array(2, 2, 1, 10);

Console.WriteLine("Матрциа 1");

Show2Array(array1);

Console.WriteLine("Матрица 2");

int[,] array2 = Start2Array(2, 2, 1, 10);

Show2Array(array2);

Console.WriteLine("Матрица X = Матрица 1 x Матрица 2");

int[,] resultArray = MatrixMultiplication(array1, array2);

Show2Array(resultArray);



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
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            newArray[i, j] = 0;
            
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                newArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return newArray;
}