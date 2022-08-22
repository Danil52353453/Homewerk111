//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] array = new int[5];
Random rnd = new Random();
int A=0;
int sum=0;
Console.WriteLine("Массив");
for (int i = 0; i < 5; i++)
{
    array[i] = rnd.Next(10, 99);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив ");
Array.Sort(array);

foreach (int b in array)
{
    Console.Write("{0} ", b);
    if (b % 2 == 1)
    {
        A++;
        sum+=b;  
    }
}
Console.WriteLine();
Console.WriteLine(" Сумма нечетных элементов = {0}",sum);