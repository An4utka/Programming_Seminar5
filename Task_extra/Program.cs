// Доп.Задача Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int length = new Random().Next(1, 10);
int[] array = new int[length];
array[0] = new Random().Next(0, 10);
Console.Write("[" + array[0]);
for (int i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(", " + array[i]);
}
Console.Write("]");
Console.WriteLine("");

int lengthNew = 0;
if (array.Length % 2 == 0)
{
    lengthNew = array.Length / 2;
}
else
{
    lengthNew = array.Length / 2 + 1;
}

int[] arrayNew = new int[lengthNew];
int currentLengthNew = array.Length - 1;
Console.Write("[");
for (int i = 0; i < lengthNew; i++)
{
    if (i != currentLengthNew)
    {
        int mult = array[i] * array[currentLengthNew];
        currentLengthNew = currentLengthNew - 1;
        arrayNew[i] = mult;
        Console.Write(" " + arrayNew[i]);
    }
    else
    {
        arrayNew[currentLengthNew] = array[i];
        Console.Write(" " + arrayNew[currentLengthNew]);
    }
}
Console.Write("]");
