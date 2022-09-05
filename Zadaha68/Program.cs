﻿//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkermans(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkermans(m - 1, 1);
    else if (m > 0 && n > 0) return Akkermans(m - 1, Akkermans(m, n - 1));
    else return n + 1;
}

Console.WriteLine($"Функция Аккермана лля заданных чисел: {Akkermans(2, 3)}");
