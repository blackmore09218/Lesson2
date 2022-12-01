/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int SumNumbersMN( int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        return sum;
    }
    else
    {
        sum+=numberM;
        return SumNumbersMN(numberM+1, numberN, sum);
    }
}

int userNumberM = GetNumber("Введите число M:  ");
int userNumberN = GetNumber("Введите число N:  ");
Console.WriteLine();
int sum = 0;
int sumNumbersMN = SumNumbersMN(userNumberM, userNumberN, sum);
Console.WriteLine($"Сумма чисел от {userNumberM} до {userNumberN} равна: {sumNumbersMN}");
