/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.WriteLine("Введите количество элементов массива   ");
int number=int.Parse(Console.ReadLine());
int[] InitArray() 
{     
    int[] result = new int[number];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-1000,1000);     
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
int Summ = 0;
for (int i = 0; i < array.Length; i+=2) Summ+=array[i];
Console.Write("Сумма элементов массива на четных позициях  -   ");
Console.Write(Summ);