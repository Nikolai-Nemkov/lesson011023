// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача № 36");
Console.WriteLine();

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int size = 4;
int[] numbers = new int[size];
ArrayRandom(numbers);
PrintArray(numbers);

int sumNumIndex = 0;   

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumIndex += numbers[i];
}
Console.Write(sumNumIndex);

Console.WriteLine();

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();