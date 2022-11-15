/*Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел > 0 ввел пользователь*/
Console.WriteLine("Введите количество чисел, которые собираетесь ввести:   ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i=1; i<M+1; i++)
{
    Console.WriteLine($"Введите очередное число. Количество чисел, которое осталось ввести: {M-i+1}");
    int CurrentNumber = int.Parse(Console.ReadLine());
    if (CurrentNumber > 0) count+=1;
}
Console.WriteLine($"Количество введенных положительных чисел: {count}");
