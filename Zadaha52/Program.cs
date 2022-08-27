// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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

void FindMean(int[,] array, int m, int n)
{
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array[i, j];
        }
        Console.Write(Math.Round(sum / m, 1) + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте колличество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колличество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
PrintArray(FillArray(array, m, n));
Console.WriteLine();
FindMean(array, m, n);


