void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; i < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    }
}

void FillArray (int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; i < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(1,1000);
        }
    }
}
string[,] table = new string[2,3];