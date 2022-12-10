// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
   {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]} ");
   }

    return array;
}

int EventArray(int [] array)
{
  
    int caunt = 0;
    for (int x = 0; x < array.Length; x++)
    {
        if (array[x] % 2 == 0)
            caunt= caunt+ 1;
   
    }
    return caunt;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
array = CreateArray(size);
int x = EventArray(array);
Console.WriteLine($"четных чисел {x} ");

