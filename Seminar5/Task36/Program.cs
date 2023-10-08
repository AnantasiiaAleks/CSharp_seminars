//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных индексах.

using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
        foreach (int number in array)
        {
            Console.Write(number + "\t");
        }
        Console.WriteLine();

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}