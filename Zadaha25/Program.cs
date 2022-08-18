// Напишите цикл который принимает на вход два числа (А и В) и возводит число А в натуральную степень В

int Fit(int a, int b)
{
    return Convert.ToInt32(Math.Pow(a, b));
}

Console.Write("Введите целое число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Число А в степени В равно: " + Fit(A, B));
