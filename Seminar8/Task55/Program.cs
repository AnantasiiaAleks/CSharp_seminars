// Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. 
// = транспонирование матрицы

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

int[,] Transposition (int[,] matrix)
{
    int[,] transMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            transMatrix[column, row] = matrix[row, column];
        }
    }
    return transMatrix;
}

const int Rows = 4;
const int Columns = 5;
const int LeftBorder = 1;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] myTransMatrix = Transposition(myMatrix);
PrintMatrix(myTransMatrix);
