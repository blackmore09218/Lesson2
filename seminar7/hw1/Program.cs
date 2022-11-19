/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void FillArray (double[,] matr)
{
    Random rnd = new Random();
    int meandr = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (rnd.Next(2) == 0) meandr =1;
            else meandr = -1;
            matr[i,j] = rnd.NextDouble()*1000*meandr;
        }
    }
}
void PrintArray (double[,] matr)
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
Console.WriteLine("Введите количество строк массива - m:  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива - n:  ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = new double[m,n];
FillArray(matrix);
PrintArray(matrix);