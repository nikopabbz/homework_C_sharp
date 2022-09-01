// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.Write("Введите число а > ");
string a = Console.ReadLine() ?? "0";
System.Console.Write("Введите число b > ");
string b = Console.ReadLine() ?? "0";
int one = int.Parse(a);
int two = int.Parse(b);
if (one > two) 
{
    System.Console.WriteLine($"Число {one} больше");
}
else
{
    System.Console.WriteLine($"Число {two} больше"); 
}
