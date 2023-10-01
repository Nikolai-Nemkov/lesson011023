// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача № 34");
Console.WriteLine();

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

Console.WriteLine("Введите  размер массива");  // kол-во 3х значных цифр.
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] numbers = new int[size];    //   введенный размер массива
int count = 0;

ArrayRandomNumbers(numbers);   // Array - массив, RandomNumbers - случайные числа
PrintArray(numbers);          // вывод чисел на печать 

for (int i = 0; i < numbers.Length; i++) //  индекс начинается от 0, он меньше (Length) - длины массива, на ед увеличиваем.
{
    if (numbers[i] % 2 == 0)     // если цифры делятся без остатка
    count++;                     // счетчик пробегает по массиву

}

Console.WriteLine();

Console.WriteLine($"количество чётных чисел в массиве -> {count} ");   

void ArrayRandomNumbers(int[] array)     // метод void возвращает значения
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);      //  означает введение 3х значных цифр
    }
}
void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
 