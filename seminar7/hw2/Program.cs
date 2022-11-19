/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(1,1000);
        }
    }
}

Console.WriteLine("Введите количество строк массива - m:  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива - n:  ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Введите номер строки массива:  ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива:  ");
int col = int.Parse(Console.ReadLine());
if (row > m || col > n) Console.WriteLine("Такого числа в массиве нет");
else
{
    Console.WriteLine(matrix[row,col]);
}