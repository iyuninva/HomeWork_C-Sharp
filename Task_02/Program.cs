﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Добрый день! Задача №2");

Console.Write("Введите число №1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное число №1 равное: " + a);
    Console.WriteLine("Минимальное число №2 равное: " + b);
}
else
{
    Console.WriteLine("Максимальное число №2 равное: " + b);
    Console.WriteLine("Минимальное число №1 равное: " + a);
}