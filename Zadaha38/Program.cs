// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами масси

double[] generateArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}
void findDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min){min = array[i];}
        if (array[i] > max){max = array[i];}
    }
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (max - min));
}

double[] newArray = new double[10];
findDifference(generateArray(newArray));
