//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.WriteLine("Enter figures separated by a space: ");
string strInputNumbers = Console.ReadLine();

int[] intNumberArray = UserArray(strInputNumbers); // задаем массив элементы считываются из строки 

Console.WriteLine($"{String.Join(" ", intNumberArray)}"); // проверяем созданный массив

Console.WriteLine($"The number of positive figures in the array is {PositiveNums(intNumberArray)}");

int[] UserArray(string strLocalInputNumbers) // входные данные числа из строки 
{
    string[] strArrNumbers = strLocalInputNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries); // преобразуем строку в массив чисел 
    int[] intLocalNumberArray = new int[strArrNumbers.Length];
    for (int i = 0; i < intLocalNumberArray.Length; i++)
    {
        intLocalNumberArray[i] = Convert.ToInt32(strArrNumbers[i]); //заполняем массив числами из строки 
    }
    return intLocalNumberArray;
}

int PositiveNums(int[] intLocalArray)
{
    int count = 0;
    for (int i = 0; i < intLocalArray.Length; i++)
    {
        if (intLocalArray[i] > 0) count++;
    }
    return count;
}