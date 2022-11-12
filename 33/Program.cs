/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
int[] InitArray() 
{     
    int[] result = new int[12];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1,100);     
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
Console.WriteLine("Введите число:    ");
int number = int.Parse(Console.ReadLine());
bool a = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]==number)
    {
        Console.WriteLine("да");
        a=true;
        break;
    }
}
if (a==false)  Console.WriteLine("нет");
