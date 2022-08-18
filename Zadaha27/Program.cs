// Напишите программу которая принимает на вход число и выдает сумму цифр в числе

int str(string num)
{
    int sum = 0;
    for(int i = 0; i < num.Length; i++)
    {
        sum += int.Parse(num[i].ToString());
    }
    return sum;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();

Console.WriteLine("Сумма цифр в числе: " + str(number));