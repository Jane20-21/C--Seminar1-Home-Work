// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь 
Console.Write("Введите произвольное колличество чисел через запятую: ");
string str = Console.ReadLine();
string[] strArray = str.Split(',');
int[] array = new int[strArray.Length];
for(int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(strArray[i]);
}

int countNumber(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine("Колличество положительных чисел равно: " + countNumber(array));