/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

string MiddleValueStr (int[,] matr, int numberOfColumn, int rows)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += matr[i, numberOfColumn];
    }
    double middleValue = sum/rows;
    return middleValue.ToString()+" ";
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите целочисленные значения элементов массива в количестве {rows*columns} через пробел:   ");
string[] values = Console.ReadLine().Split(' ');
int[,] matrix = new int[rows,columns];
for (int i=0; i < rows; i++)
{
    for (int j=0; j < columns; j++)
    {
        matrix[i,j] = int.Parse(values[columns*i+j]);
    }
}
Console.WriteLine();
PrintArray(matrix);
string answer = "Среднее арифметическое каждого столбца: ";
for (int i = 0; i < columns; i++)
{
    answer+=MiddleValueStr(matrix, i, rows);
}
Console.WriteLine(answer);