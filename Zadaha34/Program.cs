// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет колличество четных чисел в массиве

int[] generateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}

void findEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0){count++;}
    }
    Console.WriteLine("Колличество четных чисел в массиве: " + count);
}

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
findEven(generateArray(array));
