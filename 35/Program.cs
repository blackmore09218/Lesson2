/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
int[] InitArray() 
{     
    int[] result = new int[123];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1,200);
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
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>9 && array[i]<100) count+=1;
}
Console.WriteLine($"Попадают в отрезок   {count}");