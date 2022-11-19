/*ЗЗадача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/
void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=i+j+i*j;
        }
    }
}
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
Console.WriteLine("Введите количество строк массива - m:  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива - n:  ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum+=matrix[i,j];
        }
}
Console.WriteLine(sum);