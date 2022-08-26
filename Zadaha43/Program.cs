// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y=k1*x+b1; y=k2*x+b2 значения b1,k1,b2 и k2 задаются пользователем

Console.WriteLine("Введите значение к1 для уравнения y=k1*x+b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1 для уравнения y=k1*x+b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение к2 для уравнения y=k2*x+b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2 для уравнения y=k2*x+b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void intersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: X={x}, Y={y}");
}

intersectionPoint(k1, k2, b1, b2);