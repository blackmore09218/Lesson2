/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите число:");
string NumberStr = Console.ReadLine();
int Sum = 0;
for (int i = 0; i < NumberStr.Length; i++)
{
    string buffer = NumberStr[i].ToString();
    int CurrentDigit = int.Parse(buffer);
    Sum+=CurrentDigit;
}
Console.WriteLine("Сумма цифр введенного числа - "+Sum);