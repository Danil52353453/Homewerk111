//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] array = new int[4];
Random rnd = new Random();
int A=0;
Console.WriteLine("Массив");
for (int i = 0; i < 4; i++)
{
    array[i] = rnd.Next(100, 999);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив ");
Array.Sort(array);

foreach (int b in array)
{
    Console.Write("{0} ", b);
    if (b % 2 == 0)
    {
        A++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0},",A);
