/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
int[] InitArray() 
{     
    int[] result = new int[12];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);     
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
for (int i = 0; i < array.Length; i++)
{
    array[i]*=-1;
}
PrintArray(array);
