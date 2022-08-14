/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Enter numbers separated by spaces: ");
string[] input = Console.ReadLine().Split();
int[] arrNumbers = new int[input.Length];
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    arrNumbers[i] = int.Parse(input[i]);
}
for (int i = 0; i < arrNumbers.Length; i++)
{
    if (arrNumbers[i] > 0)
    {
        count++;
    }
}

PrintArray(arrNumbers);
Console.Write($"-> {count}");

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write(arr[i] + ", ");
    }
}