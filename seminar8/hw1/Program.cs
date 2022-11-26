/*Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
Например, задан массив 
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
 7 4 2 1
 9 5 3 2
 8 4 4 2*/

int[,] InitArray (int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i,j] = rnd.Next(10,100);
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
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

void SortRow(int[,] matr, int numberOfRow)
{
    int max = 0;
    int indexOfMax = 0;
    for (int i = 0; i < matr.GetLength(1)-1; i++)
    {
        max = matr[numberOfRow, i];
        indexOfMax = i;
        for (int j = i+1; j < matr.GetLength(1); j++)
        {
            if (max < matr[numberOfRow, j])
            {
                max = matr[numberOfRow, j];
                indexOfMax = j;
            }
        }    
        matr[numberOfRow, indexOfMax] = matr[numberOfRow, i];
        matr[numberOfRow, i] = max;
    }
}

Console.WriteLine("введите количество строк: ");
int numberOfRows = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int numberOfColumns = int.Parse(Console.ReadLine());
int[,] matrix = InitArray(numberOfRows, numberOfColumns);
PrintArray(matrix);
for (int k = 0; k < numberOfRows; k++)
{
    SortRow(matrix, k);
}
Console.WriteLine();
PrintArray(matrix);