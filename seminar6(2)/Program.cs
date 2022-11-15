/*Задача 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями у=к1*x+b1, y=k2*x+b Значения k1, b1, k2, b2 задаются пользователем*/
Console.WriteLine("Введите значение коэффициента k1 1-й прямой:   ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента b1 1-й прямой:   ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента k2 2-й прямой:   ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение коэффициента b2 2-й прямой:   ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Координаты точки пересечения функций y=({k1})x+({b1}) и y=({k2})x+({b2})  ->  ({(b2-b1)/(k1-k2)};{k1*(b2-b1)/(k1-k2)+b1})");