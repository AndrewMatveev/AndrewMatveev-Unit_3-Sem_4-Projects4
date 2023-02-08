// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

string InsernNumber(string dialogue)
{
    System.Console.Write(dialogue);
    return System.Console.ReadLine()!;
}

int SumNum(string num)
{
    int Sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        Sum = Sum + Convert.ToInt32(Convert.ToString(num[i]));
    }
    return Sum;
}

var number = InsernNumber("Insert the number: ");
System.Console.WriteLine($"Sum numeral of number is {SumNum(number)}");