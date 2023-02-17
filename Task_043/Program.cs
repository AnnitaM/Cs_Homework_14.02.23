//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.WriteLine("Enter the numbers separated by a space: ");
int[] array = UserArray(Console.ReadLine()); //задаем массив элементы считываются из строки 
//Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine();
Console.WriteLine($"The number of positive numbers in array is {posNum(array)}");

int[] UserArray(string numbers) //входные данные числа из строки 
{
    string[] nums = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);//преобразуем строку в массив чисел 
    int[] res = new int[nums.Length];
    for (int i = 0; i < res.Length; i++)
    {
        array[i] = Convert.ToInt32(nums[i]);//заполняем массив числами из строки 
    }
    return res;
}

int posNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}