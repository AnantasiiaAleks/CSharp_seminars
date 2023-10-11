// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, 
// находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for(int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

int SumElementsOfMainLine(int[,] matrix)
{
    int sum = 0;
    for(int i =0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for(int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

const int Rows = 5;
const int Columns = 4;
const int LeftBorder = 1;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
int sumMainLine = SumElementsOfMainLine(myMatrix);
Console.WriteLine($"Сумма элементов главной линии = {sumMainLine}.");