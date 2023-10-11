// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

using System.Numerics;

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorger)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorger + 1);
        }
    }
    return matrix;
}

void PowElementsOfMatrix(int[,] matrix)
{
    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 2; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 || j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
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

const int Rows = 3;
const int Columns = 4;
const int LeftBorder = 1;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
Console.WriteLine();
PowElementsOfMatrix(myMatrix);
PrintMatrix(myMatrix);