/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int count, int number)
{
    if (count >= number)
    {
        Console.Write($"{count} ");
        PrintNumbers(count-1, number);
    }
}

int userNumber = GetNumber("Введите число :  ");
PrintNumbers(userNumber, 1);