// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.WriteLine("Задайте колличество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колличество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(m, n));

