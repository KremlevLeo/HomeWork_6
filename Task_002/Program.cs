/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/
double[] GetCoordinates()
{
    double coordinCount = 0;
    Console.Write("b, k separated by spaces: ");
    string[] input = Console.ReadLine().Split();
    double[] coordinatуs = new double[input.Length];
    for (int i = 0; i < coordinatуs.Length; i++)
    {
        coordinatуs[i] = Convert.ToDouble(input[i]);
    }
    return coordinatуs;
}
Console.Write("Enter Line 1 ");
double[] lineA = GetCoordinates();
Console.Write("Enter Line 2 ");
double[] lineB = GetCoordinates();

double x = -(lineA[1] - lineB[1])/(lineA[0]-lineB[0]);
double y = lineB[0]*x+lineB[1];
Console.WriteLine($"b1 = {lineA[0]}, k1 = {lineA[1]}, b2 = {lineB[0]}, k2 = {lineB[1]} -> ({x};{y})");