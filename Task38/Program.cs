// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[10];
double num0 = new Random().Next(0, 100) + new Random().NextDouble();
array[0] = Math.Round(num0, 2);
Console.Write("[" + array[0]);
for (int i = 1; i < array.Length; i++)
{
    double num = new Random().Next(0, 100) + new Random().NextDouble();
    array[i] = Math.Round(num, 2);
    Console.Write(", " + array[i]);
}
Console.Write("]");
Console.WriteLine("");
double max = array[0];
double min = array[0];
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
