// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
array[0] = new Random().Next(100, 1000);
Console.Write("[" + array[0]);

for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(", " + array[i]);
}
Console.Write("]");
Console.WriteLine("");
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2==0)
    {
        countEven += 1;
    }
}
Console.WriteLine("Number of even numbers: " + countEven);
