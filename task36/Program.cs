// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int FindSums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];         
    }
    return sum;
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях {FindSums(array)}");

