// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Введите количество вводимых чисел");
// int len = int.Parse(Console.ReadLine()!);
// // Console.WriteLine("Вы ввели массив: ");
// // Console.WriteLine(String.Join("|", GetArray(len)));
// Console.WriteLine($"{Count(GetArray(len))} числа больше 0");

// int[] GetArray(int lenght)
// {
//     int[] array = new int[lenght];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число");
//         array[i] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// int Count (int[] arr){
//     int count = 0;
//     for (int i=0; i<arr.Length;i++){

//         if (arr[i]>0) 
//         {
//             count++;
//         }
//     }
//     return count;

// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = x * k1 + b1;

Console.WriteLine ($"Координаты точки пересечения двух прямых х={x:f1}, y={y:f1}");