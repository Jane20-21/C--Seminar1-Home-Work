// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

void NewArray(int[] dif)
{
    for(int i = 0; i < dif.Length; i++)
    {
        dif[i] = new Random().Next(1, 10);
        Console.Write($"{dif[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[8];
NewArray(array);
