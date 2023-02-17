/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
массив рандом мин/макс сложить числа и разделить на их кол-во
x:0.00 - округление
*/

using System;
using static System.Console;

Clear();
Write("Enter the number of array rows: ");
int rows = int.Parse(Console.ReadLine());
Write("Enter the number of array columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

int[] avr = new int[columns];

//Write($"arithmetic mean of the elements in each column {}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

int GetAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avr[i] += array[j,i];
        }
    }
    foreach (double elem in array) sum += item;
    avr = sum / columns;
    return avr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}






/*
using System;
using static System.Console;

Clear();
Write("Enter the number of array rows: ");
int rows = int.Parse(Console.ReadLine());
Write("Enter the number of array columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetArray(rows, columns, 0, 10);

Write($"Arithmetical meanof each column{GetAverage(matrix)}");

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

float[] GetAverage(int[,] matrix)
{
    int sum = 0;
    float avr;
    //for (int i = 0; i < rows; i++){ sum += matrix[i, j]; }
    foreach (int elem in matrix) sum += item;
    avr = sum / columns;
    return avr;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

*/

