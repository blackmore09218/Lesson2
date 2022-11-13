/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.WriteLine("Введите количество элементов массива   ");
int number=int.Parse(Console.ReadLine());
int[] InitArray() 
{     
    int[] result = new int[number];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100,1000);     
    }     
    return result;
}
void PrintArray(int[] array)
{  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 
int[] array = InitArray();
PrintArray(array);
int NumberOfEven = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0) NumberOfEven+=1;
}
Console.Write("Количество четных элементов массива  -   ");
Console.Write(NumberOfEven);