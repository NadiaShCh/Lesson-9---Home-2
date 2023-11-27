﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число M");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetSum(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    return start + GetSum(start+1, end);

}
System.Console.WriteLine(GetSum(num1, num2));
