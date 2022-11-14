// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int OddNumber(int[] array)
{
    int sum=0;
    for (int i=1; i<array.Length; i=i+2)
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