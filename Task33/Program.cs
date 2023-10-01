// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



int[] CreateArrayRndInt(int size, int min, int max)
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
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    // Console.WriteLine("]"); если добавим в метод, то скобки будут выводится всегда. Если скобки не критичны, то стоит выводить за метод.
}

bool FindNumber (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] == num)
        {
            return true;
        }

    }
    return false;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
Console.Write(" [");
PrintArray(array);
 Console.WriteLine("]");

 bool findNumber = FindNumber(array, number);
 Console.WriteLine(findNumber ? "Число найдено ": "Число не найдено");

