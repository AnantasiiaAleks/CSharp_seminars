// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов
// в каждом столбце.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        } 
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
       int[,] matrix = new int[n, m];
        int currentValue = 1;
        for(int i =0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentValue;
                    currentValue += k;
                }
        }
        return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
        Console.WriteLine("The averages in columns are:");
        foreach (double number in list)
        {
            Console.Write($"{number:F2}\t");
        }
        Console.WriteLine();
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
        double[] averages = new double[matrix.GetLength(1)];
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            double sum = 0.00;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, column];
            }
            averages[column] = sum/matrix.GetLength(0);
        }
        return averages;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}