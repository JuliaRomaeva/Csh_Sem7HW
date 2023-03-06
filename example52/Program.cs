// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
double[] result = Result(array);
double[] Result(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)]; // создаем пустой одномерный массив для хранения значений среднего арифметического
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double sum = 0; // задаем сумму чисел в столбце
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum+=inArray[j,i]; // находим сумму всех чисел в столбце
        }
        result[i] = sum / inArray.GetLength(0); //вычисляем ср.арифметическое
    }
    return result;
}

WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ",Result(array)):f1}");