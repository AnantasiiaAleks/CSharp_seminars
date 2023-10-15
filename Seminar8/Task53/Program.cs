// Задайте двумерный массив. Напишите программу
// которая поменяет местами первую и последнюю
// строку массива.

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

void ChangeRows(int[,] matrix)
{
    int temp = 0;
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        temp = matrix[0, column];
        matrix[0, column] =  matrix[matrix.GetLength(0) - 1, column];
        matrix[matrix.GetLength(0) - 1, column] = temp;
    } 
}

const int Rows = 5;
const int Columns = 3;
const int LeftBorder = 1;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
Console.WriteLine();
ChangeRows(myMatrix);
PrintMatrix(myMatrix);

