//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным значением
//элементов массива.

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
      double max = array[0];
      for(int i = 0; i < array.Length; i++)
      {
        if (max < array[i])
        {
          max = array[i];
        }
      }
      return max;       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
      double min = array[0];
      for(int i = 0; i < array.Length; i++)
      {
        if (min > array[i])
        {
          min = array[i];
        }
      }
      return min;       
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
        double maxim = FindMax(array);
        double minim = FindMin(array);
        double difference = maxim - minim;
        return difference;
    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
        foreach (double number in array)
        {
            Console.Write(number + "\t");
        }
        Console.WriteLine();
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
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

        Console.WriteLine("Массив:");
        PrintArray(array);
        double maxValue = FindMax(array);
        double minValue = FindMin(array);
        Console.WriteLine($"Максимальное {maxValue}, минимальное {minValue}");
        //double diff = maxValue - minValue;
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}