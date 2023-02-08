// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


System.Console.Write("Введите число N: ");
string? vvod = Console.ReadLine();
System.Console.Write(vvod!.Length);