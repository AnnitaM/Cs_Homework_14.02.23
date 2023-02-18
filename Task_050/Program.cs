/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7] -> такого числа в массиве нет
*/

/*
искомые числа и массив с консоли и по индексу опр есть ли такое число в массиве
*/

using System;
using static System.Console;

Clear();
Write("Enter the number of array rows: ");
int intRows = int.Parse(Console.ReadLine());
Write("Enter the number of array columns: ");
int intColumns = int.Parse(Console.ReadLine());
Write("Enter the coordinates separated with space: ");
string strInputCoord = Console.ReadLine();


int[,] intArray = GetArray(intRows, intColumns, 0, 10);
PrintArray(intArray);
int[] intCoordArray = CoordArray(strInputCoord); // преобразовали в массив строку из консоли


if (intArray.GetLength(0) >= intCoordArray[0] && intArray.GetLength(1) >= intCoordArray[1])
{
    Write($"the number is {intArray[intCoordArray[0], intCoordArray[1]]}");
}
    else Write("There is no such number");


int[] CoordArray(string strLocalInputNumbers)
{
    string[] strArrNumbers = strLocalInputNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries); // преобразуем строку в массив чисел 
    int[] intLocalNumberArray = new int[strArrNumbers.Length];
    for (int i = 0; i < intLocalNumberArray.Length; i++)
    {
        intLocalNumberArray[i] = Convert.ToInt32(strArrNumbers[i]); //заполняем массив числами из строки 
    }
    return intLocalNumberArray;
}


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