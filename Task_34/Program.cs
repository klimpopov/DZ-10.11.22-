// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Massive(int size, int min, int max)
{
    int[] array = new int[size];
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Размер массива = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальный элемент массива: трехзначное число = ");
int min = Convert.ToInt32(Console.ReadLine());
if (min < 100 || min > 999)
{
    Console.Write("Число должно быть трехзначным");
}
else
{
    Console.Write("Максимальный элемет массива: трехзначное число = ");
    int max = Convert.ToInt32(Console.ReadLine());
    if (max < 100 || max > 999)
    {
        Console.Write("Число должно быть трехзначным");
    }
    else
    {
        int[] array = Massive(size, min, max);
        Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
        int count = EvenNumber(array);
        Console.WriteLine($"Количество четных чисел = {count}");
    }
}