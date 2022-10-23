/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();*/
Console.WriteLine("Введите элементы массива, разделяя их одним пробелом");
string NumbersStr = Console.ReadLine();
string[] array = NumbersStr.Split();
Console.Write("[");
for (int i = 0; i < array.Length-1; i++) Console.Write(array[i]+", ");
Console.Write(array[array.Length-1]+"]");