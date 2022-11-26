/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] InitArray (int x, int y, int z)
{
    int[,,] matr = new int[x, y, z];
    Random rnd = new Random();
    for (int k = 0; k < z; k++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int i = 0; i < x; i++)
            {
                matr[i,j,k] = rnd.Next(1,10);
            }
        }
    }
    return matr;
}

Console.WriteLine("введите 'высоту' массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите 'ширину' массива: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("введите 'глубину' массива : ");
int z = int.Parse(Console.ReadLine());
int[,,] matrix3D = InitArray(x,y,z);
for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{matrix3D[i,j,k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
