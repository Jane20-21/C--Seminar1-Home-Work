// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Напишите целое число: ");
int num = int.Parse(Console.ReadLine());
string str = num.ToString();
if (str.Length < 3)
{
    Console.WriteLine("В заданном числе третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра заданного числа: " + str[2]);
}