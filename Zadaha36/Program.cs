// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях

int[] generateArray(int length = 10, int min = 0, int max = 100)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}

int findSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = generateArray();
Console.WriteLine("Сумма элементов стоящих на нечетных позициях: " + findSum(array));
