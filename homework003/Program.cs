// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
System.Console.Write("Введите число > ");
string a = Console.ReadLine() ?? "0";
int one = int.Parse(a);
if (one % 2 == 0) 
{
    System.Console.WriteLine($"Число {one} четное");
}
else
{
    System.Console.WriteLine($"Число {one} нечетное"); 
}
