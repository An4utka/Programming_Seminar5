// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array=new int[10];
array[0]=new Random().Next(100,1000);
Console.Write("["+array[0]);
for (int i=1; i<array.Length; i++)
{
array[i]=new Random().Next(100,1000);
Console.Write(", "+array[i]);
}
Console.Write("]");
int sumUnevenPositionElements=0;
for (int i=0; i<array.Length; i++)
{
if (i%2>0)
{
sumUnevenPositionElements+=array[i];
}
}
Console.WriteLine("");
Console.WriteLine("Sum of the elements that are on an uneven position: " + sumUnevenPositionElements);

