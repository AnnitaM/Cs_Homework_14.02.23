/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
// min = 5
// max = 9
// double p=new Random().NextDouble()*(max-min)+min // вещественные числа

using System;
using static System.Console;

Clear();
Write("Enter the number of array rows: ");
int intM = int.Parse(Console.ReadLine());
Write("Enter the number of array columns: ");
int intN = int.Parse(Console.ReadLine());

Write("Enter minimum value: ");
double doubMin = double.Parse(Console.ReadLine());
Write("Enter maximum value: ");
double doubMax = double.Parse(Console.ReadLine());

double[,] doubArray = GetArray(intM, intN, doubMax, doubMin);

PrintArray(doubArray);

double[,] GetArray(int intLocalM, int intLocalN, double doubLocalMax, double doubLocalMin)
{
    double[,] doubLocalResult = new double[intLocalM, intLocalN];
    for (int i = 0; i < intLocalM; i++)
    {
        for (int j = 0; j < intLocalN; j++)
        {
            doubLocalResult[i, j] = new Random().NextDouble()*(doubLocalMax - doubLocalMin) + doubLocalMin;
        }
    }
    return doubLocalResult;
}

void PrintArray(double[,] doubLocalArray)
{
    for (int i = 0; i < doubLocalArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubLocalArray.GetLength(1); j++)
        {
            Write($"{doubLocalArray[i, j]:0.0} ");
        }
        WriteLine();
    }
}

//Console.WriteLine("Hello, World!");
