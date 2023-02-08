// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double InsernNumber (string dialogue)
{
    System.Console.Write(dialogue);
    return Convert.ToDouble(Console.ReadLine());
}

double Pow(double num1, double num2)
{
    return Math.Pow(num1, num2);
}

double A = InsernNumber("Введите число А: ");
double B = InsernNumber("Введите число В: ");


System.Console.WriteLine($"{A} в степени {B} равно {Pow(A, B)}");