// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количество вводимых чисел");
int len = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Вы ввели массив: ");
// Console.WriteLine(String.Join("|", GetArray(len)));
Console.WriteLine($"{Count(GetArray(len))} числа больше 0");

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int Count (int[] arr){
    int count = 0;
    for (int i=0; i<arr.Length;i++){

        if (arr[i]>0) 
        {
            count++;
        }
    }
    return count;

}