// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов
// в каждом столбце.

using System;

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
        foreach (int number in list)
        {
            Console.Write(number + "\t");
        }
        Console.WriteLine();
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
        // int size = matrix.GetLength(1);
        double[] list = new double[matrix.GetLength(1)];
        for (int i = 0; i < list.Length; i++)
        {
            list[i] = 
        }
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