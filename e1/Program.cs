﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());

double PrintNumbers(double start, double end)
{
    if (start==end)
    {
        return (end);
    }
    return (start+PrintNumbers(start,end));
}
Console.WriteLine(PrintNumbers(number,1));