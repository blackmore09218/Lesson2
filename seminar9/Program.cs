/*Вывести все числа от М до N с помощью рекурсии*/
/*int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers( int numberM, int numberN)
{
    if (numberM <= numberN)
    {
        Console.Write($"{numberM} ");
        PrintNumbers(numberM+1, numberN);
    }
}

int userNumberM = GetNumber("Введите число M:  ");
int userNumberN = GetNumber("Введите число N:  ");
PrintNumbers(userNumberM, userNumberN);*/

/*Вывести все числа от 1 до N с помощью рекурсии*/
/*int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int count, int number)
{
    if (count <= number)
    {
        Console.Write($"{count} ");
        PrintNumbers(count+1, number);
    }
}

int userNumber = GetNumber("Введите число :  ");
PrintNumbers(1, userNumber);*/

/*Вывести сумму цифр введенного числа*/
int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int SumOfDigits(int number, int sum)
{
    if (number / 10 == 0)
    {
        sum+=number%10;
        return sum;
    }
    else
    {
        sum+=number%10;
        return SumOfDigits(number/10, sum);
    }
}

int userNumber = GetNumber("Введите число :  ");
int sum = 0;
int sumOfDigits = SumOfDigits(userNumber, sum);
Console.WriteLine(sumOfDigits);
