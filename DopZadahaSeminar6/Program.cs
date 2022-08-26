//  Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

void printArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int sumNumber(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}

int[,] array = new int[3, 4];
printArray(array);
Console.WriteLine("Cумма элементов на диоганали массива: " + sumNumber(array));
