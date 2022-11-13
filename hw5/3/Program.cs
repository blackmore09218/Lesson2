/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.WriteLine("Введите количество элементов массива   ");
int number=int.Parse(Console.ReadLine());
double[] InitArray() 
{     
    double[] result = new double[number];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble() * 100;     
    }     
    return result;
}
void PrintArray(double[] array)
{  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 
double[] array = InitArray();
PrintArray(array);
double Max = array[0];
double Min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] >= Max) Max = array[i];
    if (array[i] <= Min) Min = array[i];
}
Console.Write("Разница между максимальным и минимальным элементами массива  -   ");
Console.Write(Max-Min);