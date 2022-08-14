// Напишите программу, которая принимает на вход координаты 2 точек и находит расстояние между ними в 3D пространстве
double distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dis = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return dis;
}

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите хA:");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yA:");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zA:");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Введите хB:");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите yB:");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите zB:");
int zb = int.Parse(Console.ReadLine());

Console.WriteLine($ "Расстояние между точками равно: {distance(xa, ya, za, xb, yb, zb)}");
