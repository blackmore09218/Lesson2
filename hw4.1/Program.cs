/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите основание, число А:");
double numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите показатель степени, число В:");
int numberB = int.Parse(Console.ReadLine());
double result = 1;
for (int i = 1; i <= numberB; i++) result *= numberA;
Console.WriteLine("Результат  "+result);