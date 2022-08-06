// Ниписать программу, которая на вход принимает 2 числа и выдает какое число больше, а какое меньше
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB){Console.WriteLine("Первое число больше второго и равно: " + numberA);}
if (numberA < numberB){Console.WriteLine("Второе число больше первого и равно: " + numberB);}