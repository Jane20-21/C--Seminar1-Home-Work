// Напишите программу, которая принимает на вход цифру обозначающую день недели, и проверяет, является ли этот день выходным
// Вариант 1
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine("Введите число,которое соответствует дню недели от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day < array[0] || day > array[6])
{
    Console.WriteLine("Вы ввели неверный день недели");
}
else if (day < array[5])
{
    Console.WriteLine("Это не выходной");
}
else
{
    Console.WriteLine("Это выходной");
}

// Вариант 2
/*
Console.WriteLine("Введите число,которое соответствует дню недели от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.WriteLine("Вы ввели неверный день недели");
}
else if (day < 6)
{
    Console.WriteLine("Это не выходной");
}
else
{
    Console.WriteLine("Это выходной");
}
*/