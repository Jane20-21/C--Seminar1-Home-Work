// Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число большее 1 ");
int N = int.Parse(Console.ReadLine());

if (N < 1){Console.WriteLine("Вы ввели число меньше 1");}

int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine("Четное число: " + index);
    }
    index ++;
}