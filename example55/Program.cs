// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
Write("Введите минмальное значение: ");
int min=int.Parse(ReadLine());
Write("Введите максимальное значение: ");
int max=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
WriteLine();

if(rows != columns){
    Write("Невозможно выполнить замену");
    return;}

PrintArray(ChangeRowsColumns(array));

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
int[,] ChangeRowsColumns(int[,] inArray)
{
    int[,] result = new int [inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
            result[j, i] = inArray[i, j];
            }
        }
        return result;
    }

// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());



// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// PrintArray(ChangeArray1(array));
// WriteLine();
// PrintArray(array);
// WriteLine();
// ChangeArray2(array);
// PrintArray(array);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[,] ChangeArray1(int[,] array)
// {
//     int[,] result = new int [array.GetLength(1), array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }

// void ChangeArray2(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         WriteLine("В данной матрице нельзя заменить элементы!");
//         return;
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             int k = array[j, i];
//             array[j, i] = array[i, j];
//             array[i, j] = k;
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write($"{array[i, j]} ");
//         }
//         WriteLine();
//     }
// }