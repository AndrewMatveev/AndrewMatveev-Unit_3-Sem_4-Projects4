// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] InsertArrayParametes(string parametrs)
{
    System.Console.WriteLine(parametrs);
    return Console.ReadLine().Split(",").Select(int.Parse).ToArray();
}

int[] ArrayGeneration(int size, int StartValue, int FinishValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(StartValue, FinishValue + 1);
    }
    return array;
}







int[] parameters = InsertArrayParametes("Введите через запятую седующие параметры: размер массива, начальное значение для генерации автозаполнения, конечное значение для генерации автозаполнения: ");

int[] Array = ArrayGeneration(parameters[0], parameters[1], parameters[2]);

System.Console.WriteLine($"Полученный масив: [ {string.Join("; ", Array)} ]");