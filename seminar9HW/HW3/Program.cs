/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int Akkerman( int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else 
    {
        if (numberN == 0) return Akkerman(numberM - 1, 1);
        else return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
    }
}

int userNumberM = GetNumber("Введите число M:  ");
int userNumberN = GetNumber("Введите число N:  ");
Console.WriteLine();
int akkermanValue = Akkerman(userNumberM, userNumberN);
Console.WriteLine($"A({userNumberM}, {userNumberN}) = {akkermanValue}");
