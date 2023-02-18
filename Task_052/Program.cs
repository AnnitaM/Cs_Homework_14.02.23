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
int intRows = int.Parse(Console.ReadLine());
Write("Enter the number of array columns: ");
int intColumns = int.Parse(Console.ReadLine());

int[,] intArray = GetArray(intRows, intColumns, 0, 10);
PrintArray(intArray);

double[] doubAverArray = GetAverage(intArray);
PrintDoubArray(doubAverArray);

int[,] GetArray(int intLocalM, int intLocalN, int intLocalMin, int intLocalMax)
{
    int[,] intLocalResult = new int[intLocalM, intLocalN];
    for (int i = 0; i < intLocalM; i++)
    {
        for (int j = 0; j < intLocalN; j++)
        {
            intLocalResult[i, j] = new Random().Next(intLocalMin, intLocalMax + 1);
        }
    }
    return intLocalResult;
}

double[] GetAverage(int[,] intLocalArray)
{
    double[] localAverArray = new double[intLocalArray.GetLength(0)];

    int localArrayRows = intLocalArray.GetLength(1);

    for (int i = 0; i < intLocalArray.GetLength(1); i++)
    {
        for (int j = 0; j < intLocalArray.GetLength(0); j++)
        {
            localAverArray[i] += intLocalArray[j, i];
        }
        localAverArray[i] /= localArrayRows;
    }
    return localAverArray;
}

void PrintArray(int[,] intLocalArray)
{
    for (int i = 0; i < intLocalArray.GetLength(0); i++)
    {
        for (int j = 0; j < intLocalArray.GetLength(1); j++)
        {
            Write($"{intLocalArray[i, j]} ");
        }
        WriteLine();
    }
}
void PrintDoubArray(double[] doubLocalArray)
{
    for (int i = 0; i < doubLocalArray.Length; i++)
    {
        Write($"{doubLocalArray[i]} ");
    }
}

