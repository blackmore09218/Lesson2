﻿/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());
double Rasst(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)), 2);
}
double rasstoyanie = Rasst(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {rasstoyanie}");