﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача № 38");
Console.WriteLine();
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int size = 10;
int[] numbers = new int[size];
ArrayRandomNum(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine();

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");

Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

void ArrayRandomNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
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