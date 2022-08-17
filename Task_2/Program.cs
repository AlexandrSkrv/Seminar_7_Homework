// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет



int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}


void elementSearch(int[,] matrixResult)
{
    Console.WriteLine("введите номер строки");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца");
    int m = Convert.ToInt32(Console.ReadLine());

    if (n > matrixResult.GetLength(0) || m > matrixResult.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrixResult[n - 1, m - 1]}");
    }
}

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
elementSearch(matrixResult);
