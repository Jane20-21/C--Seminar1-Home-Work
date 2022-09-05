// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N

int Sum(int m, int n)
{
    if (n == m) return m;
    else return n + Sum(m, n - 1);
}

Console.WriteLine(Sum(4, 15));
