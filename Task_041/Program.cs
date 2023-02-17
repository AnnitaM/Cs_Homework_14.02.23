// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Enter number k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Enter number b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Enter number k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.Write("Enter number b2: ");
double b2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Intersection point is X:{x:0.0} Y:{y:0.0}");

double[] findPoint(double x, double y)
{

    double[] point = new double[2];
    for (int i = 0; i < 2; i++)
    {
        point[0] = x;
        point[1] = y;
    }
    return point;
}