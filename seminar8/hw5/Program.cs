/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

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

Console.WriteLine("Ввведите значение размера стороны квадратного массива от 2 до 9: ");
int length = int.Parse(Console.ReadLine());
int[,] matrix = new int[length, length];
int n = 11;
int rowIndex = 0;
int columnIndex = 0;
matrix[0,0]=11;
while (n<length*length+10)
{
    while ((columnIndex+1 < length) && (columnIndex+1 > -1) && (matrix[rowIndex, columnIndex+1]==0))
    {
        n+=1;
        columnIndex+=1;
        matrix[rowIndex, columnIndex]=n;
    }
    while (rowIndex+1 < length && rowIndex+1 > -1 && matrix[rowIndex+1, columnIndex]==0)
    {
        n+=1;
        rowIndex+=1;
        matrix[rowIndex, columnIndex]=n;
    }
    while (columnIndex-1 < length && columnIndex-1 > -1 && matrix[rowIndex, columnIndex-1]==0)
    {
        n+=1;
        columnIndex-=1;
        matrix[rowIndex, columnIndex]=n;
    }
    while (rowIndex-1 < length && rowIndex-1 > -1 && matrix[rowIndex-1, columnIndex]==0)
    {
        n+=1;
        rowIndex-=1;
        matrix[rowIndex, columnIndex]=n;
    }
}
Console.WriteLine();
PrintArray(matrix);


















