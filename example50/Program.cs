// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Write("Введите номер строки и столбца элемента через пробел: ");
string arr = Console.ReadLine();
int[] ind = GetArrayFromString(arr);
int[] GetArrayFromString(string stringArray){
string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];
 for(int i = 0; i < nums.Length; i++ ){
 res[i] = int.Parse(nums[i]);
 }
 return res;
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

if(ind[0] > array.GetLength(0) || ind[1] > array.GetLength(1)){
    WriteLine("Такого числа нет");
}
else
{
   WriteLine($"значение элемента {ind[0]} строки и {ind[1]} столбца равно {array[ind[0] - 1,ind[1] - 1]}");
}
