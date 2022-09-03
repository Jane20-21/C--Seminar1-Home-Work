// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductArray(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            array3[i, j] = array1[i, 0] * array2[0, j] + array1[i, 1] * array2[1, j];
        }
    }
    return array3;
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] productArray = new int[2, 2];
PrintArray(FillArray(array1));
Console.WriteLine();
PrintArray(FillArray(array2));
Console.WriteLine();
PrintArray(ProductArray(array1, array2, productArray));
