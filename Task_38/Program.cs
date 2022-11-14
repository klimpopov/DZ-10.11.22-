// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] Massive(int size, int min, int max)
     {
       int[] array = new int[size];
         if (min>max)
         {
             int minTer=max; 
             int maxTer=min;
             min=minTer;
             max=maxTer; 
         }
       for (int i=0; i<size; i++)
       {
         array[i]=new Random().Next(min, max); 
       }
       return array;
     }

int DifferenceOfNumbers(int[] array)
{
    int max=array[0];
int min=array[0];
    for (int i=2; i<array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum; 
}
      
    Console.Write("Размер массива = ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальный элемент массива: трехзначное число = ");
    int min = Convert.ToInt32(Console.ReadLine());
          Console.Write("Максимальный элемет массива: трехзначное число = ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = Massive(size, min, max); 
    Console.WriteLine($"Массив: [{String.Join(", ", array)}]"); 
      int count=OddNumber(array);
      Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях = {count}");