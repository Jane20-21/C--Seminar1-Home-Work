// Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
string leg = Console.ReadLine();

if (leg.Length < 5 || leg.Length > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}
else if (leg[0] == leg[leg.Length - 1] && leg[1] == leg[leg.Length - 2])
{
    Console.WriteLine("Число является палиндромом!");
}
else
{
    Console.WriteLine("Число  не является палиндромом!");
}
