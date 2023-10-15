// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент в массиве.

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

void CountOfElements(int[,] matrix, int rightBorder)
{
    for (int k = 0; k <= rightBorder; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (k == matrix[i, j])
                {
                    count++;
                }
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"Число {k} встречается {count} раз.");
        }
    }
}

const int Rows = 5;
const int Columns = 3;
const int LeftBorder = 0;
const int RightBorder = 9;

int[,] myMatrix = GetRandomMatrix(Rows, Columns,LeftBorder,RightBorder);
PrintMatrix(myMatrix);
Console.WriteLine();
CountOfElements(myMatrix,RightBorder);

