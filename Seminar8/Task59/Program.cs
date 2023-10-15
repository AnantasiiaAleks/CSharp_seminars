// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
//

using System.Data;

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindMin(int[,] matrix)
{
    int[] minEl = new int[2];
    int min = matrix[0,0];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minEl[0] = i;
                    minEl[1] = j;
                }
            }
        }
    }
    return minEl;
}

int[,] CutMatrix (int[,] matrix)
{
    int rowOffset = 0;
    int columnOffset = 0;
    int[] minEl = FindMin(matrix);
    int[,] cutMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < cutMatrix.GetLength(0); i++)
    {
        if (i == minEl[0])
        {
            rowOffset++;
        }
        for (int j = 0; j < cutMatrix.GetLength(1); j++)
        {
            if (j == minEl[1])
            {
                columnOffset++;
            }
            cutMatrix[i, j] = matrix[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    return cutMatrix;
}

const int Rows = 3;
const int Columns = 4;
const int LeftBorder = 0;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] cutMyMatrix = CutMatrix(myMatrix);
PrintMatrix(cutMyMatrix);

