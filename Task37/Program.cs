﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача № 38");


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    // Console.WriteLine("[");
    for (int i = 0; i< arr.Length; i++)
    {
        if(i <arr.Length -1) 
        Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    // Console.WriteLine("]");
}

int[] ProductOfNums (int[] arr)
{
    //Получаем размер нового массива
    int size = arr.Length / 2 ;  
    if (arr.Length % 2 != 0) size += 1;
    // Создаём новый массив
    int[] arrNew = new int[size];
    // Заполняем новый массив произведением пар чисел
    for (int i = 0; i< arr.Length / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    // Для массивов с нечётным размеров добавляем последним элементом нового средний элемент исходного 
    if (arr.Length % 2 != 0) arrNew[arrNew.Length - 1] = arr[arr.Length / 2];
    return arrNew;
}
    
int[] array = CreateArrayRndInt(5, 1, 9);
Console.Write("[");
PrintArray (array);
Console.WriteLine("]");

int[] productOfNums = ProductOfNums(array);
Console.Write("[");
PrintArray (productOfNums);
Console.Write("]");

