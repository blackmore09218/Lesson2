/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Введите пятизначное число: ");
string NumberStr = Console.ReadLine();
string RevNumStr = "";
for (int i = 0; i<5; i++)
{
    string buffer = NumberStr[4-i].ToString();
    RevNumStr = RevNumStr.Insert(i, buffer);
}
if (NumberStr==RevNumStr) Console.WriteLine("Является палиндромом");
else Console.WriteLine("Не является палиндромом");