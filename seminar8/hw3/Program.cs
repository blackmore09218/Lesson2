/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] InitArray (int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i,j] = rnd.Next(1,10);
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

Console.WriteLine("введите количество строк первой матрицы (= количеству столбцов второй матрицы): ");
int numberOfRows = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов первой матрицы (= количеству строк второй матрицы): ");
int numberOfColumns = int.Parse(Console.ReadLine());
int[,] matrix1 = InitArray(numberOfRows, numberOfColumns);
int[,] matrix2 = InitArray(numberOfColumns, numberOfRows);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
int[,] matrixProduct = InitArray(numberOfRows, numberOfRows);
for (int i = 0; i < numberOfRows; i++)
{
    for (int j = 0; j < numberOfRows; j++)
    {
        int sum = 0;
        for (int k = 0; k < numberOfColumns; k++)
        {
           sum += matrix1[i,k]*matrix2[k,j];
        }
        matrixProduct[i,j] = sum;
    }
}
Console.WriteLine("Произведением этих двух матриц будет матрица: ");
PrintArray(matrixProduct);