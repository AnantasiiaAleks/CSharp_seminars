// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

int Value(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int a, int b)
{
    int[] array = new int[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(a, b+1);
        Console.Write(array[index] + " ");
    }
    return array;
}

int arraySize = Value("Задайте размер массива: ");
if (arraySize > 0)
{
    int minValue = Value("Задайте минимальное значение чисел массива: ");
    int maxValue = Value("Задайте максимальное значение чисел массива: ");
    Console.WriteLine("Ваш массив готов:");
    FillArray(arraySize, minValue, maxValue);
}
else
{
    Console.WriteLine("Размер массива должен быть больше 0");
}

