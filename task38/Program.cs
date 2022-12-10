

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble()* (100 - (-100)) + (-100),2);
    return array;
}
void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}


//Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");