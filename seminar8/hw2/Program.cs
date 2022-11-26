/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] InitArray (int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i,j] = rnd.Next(100,1000);
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

Console.WriteLine("введите количество строк: ");
int numberOfRows = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int numberOfColumns = int.Parse(Console.ReadLine());
int[,] matrix = InitArray(numberOfRows, numberOfColumns);
PrintArray(matrix);
int[] sumArray = new int[numberOfRows];
for (int i = 0; i < numberOfRows; i++)
{
    int sum = 0;
    for (int j = 0; j < numberOfColumns; j++)
    {
        sum += matrix[i,j];
    }
    sumArray[i] = sum;
}
int minSum = sumArray[0];
int minSumIndex = 0;
for (int i = 1; i < numberOfRows; i++)
{
    if (sumArray[i] < minSum)
    {
        minSum = sumArray[i];
        minSumIndex = i;
    }
}
Console.WriteLine();
Console.WriteLine($"{minSumIndex}-я строка с наименьшей суммой элементов");
