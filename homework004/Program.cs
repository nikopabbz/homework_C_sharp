﻿// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.Write("Введите число > ");
string N = Console.ReadLine() ?? "0";
int one = int.Parse(N);
for (int i = 1; i <= one; i++)
{
if (i % 2 == 0)
    System.Console.WriteLine(i);
}