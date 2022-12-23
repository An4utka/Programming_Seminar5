// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
array[0] = new Random().Next(0, 1000);
Console.Write("[" + array[0]);
for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(", " + array[i]);
}
Console.Write("]");
Console.WriteLine("");
int max = 0;
int min = 1000;
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
int diff = max - min;
Console.Write("Difference between max and min: " + diff);
