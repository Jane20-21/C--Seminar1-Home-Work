// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

string Numbers(int m, int n)
{
    if (m <= n) return $"{m}," + Numbers(m + 1, n);
    else return String.Empty;
}
Console.WriteLine(Numbers(1, 20));
