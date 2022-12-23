// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

float[] array = new float[10];
array[0] = new Random().Next(0, 1000);
Console.Write("[" + array[0]);
for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(", " + array[i]);
}
Console.Write("]");
Console.WriteLine("");
double max = 0;
double min = 1000;
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
double diff = max - min;
Console.Write("Difference between max and min: " + diff);
