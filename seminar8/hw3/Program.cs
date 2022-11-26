/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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