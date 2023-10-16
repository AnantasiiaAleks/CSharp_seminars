// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

using System;
using System.Data;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
        int sum = 0;
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
                sum += matrix[row, column];
        }
        return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
        int[] minimSum = new int[2];
        int min = SumOfRow(matrix, 0);
        minimSum[0] = 0;
        minimSum[1] = min;
        for (int row = 1; row < matrix.GetLength(0); row++)
        {
            int sumRow = SumOfRow(matrix, row);
            if (sumRow < min)
            {
                min = sumRow;
                minimSum[0] = row;
                minimSum[1] = min;
            }
        }
        return minimSum;
    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {1, 5, 3},
                {8, 6, 2},
                {7, 1, 5}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
    }
}