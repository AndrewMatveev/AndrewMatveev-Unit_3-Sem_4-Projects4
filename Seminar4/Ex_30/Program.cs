// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// _______ЧЕРЕЗ ОБЫЧНУЮ ФУНКЦИЮ__________________________________

// int[] GetArray()
// {
//     var arr = new int[8];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// var myArray = GetArray();
// PrintArray(myArray);

// ______________________________________________________________








// ______________ЧЕРЕЗ ВОЙД__________________________________________

void GetArray(int[] arr)
{
    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] myArray = new int[8];
GetArray(myArray); // перезаписывает myArray
PrintArray(myArray);

// __________________________________________________________________