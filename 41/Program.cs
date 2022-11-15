// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int[] array = new int[10];
int[] RandomArray(int[] arr)
{
    int size = arr.Length;;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void PositiveNumbers(int[] arr2)
{
    int count = 0;
    int size = arr2.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr2[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел после 0 = {count}");
}

RandomArray(array);
Console.WriteLine();
PositiveNumbers(array);