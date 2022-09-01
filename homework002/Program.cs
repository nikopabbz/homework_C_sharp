// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.Write("Введите число а > ");
string a = Console.ReadLine() ?? "0";
System.Console.Write("Введите число b > ");
string b = Console.ReadLine() ?? "0";
System.Console.Write("Введите число c > ");
string c = Console.ReadLine() ?? "0";
int one = int.Parse(a);
int two = int.Parse(b);
int three = int.Parse(c);
int max;
if (one > two) 
{
    max = one;
}
    else
    {
        max = two;
    }
if (three > max) 
{
    max = three;
    System.Console.WriteLine($"Число {max} максимальное");
}
    else
    {
        System.Console.WriteLine($"Число {max} максимальное");
    }
