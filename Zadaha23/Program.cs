// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

void FillArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
    }
}

void PrintArray(int[] mass)
{
    for (int a = 0; a < mass.Length; a++)
    {
        Console.WriteLine(mass[a]);
    }
}

Console.Write("Введите число N больше 1: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = new int[N];
FillArray(array);
PrintArray(array);
