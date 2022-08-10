// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
Console.WriteLine("Вторая цифра этого числа: " + str[1]);
