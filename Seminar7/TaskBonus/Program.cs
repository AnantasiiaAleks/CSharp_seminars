// Найти среднее арифметическое элементов,
//расположенных по углам массива

double[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*(rightBorder - leftBorder) + leftBorder;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
}

double FindMeanOfCornerElements(double[,] matrix)
{
    double mean = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            mean = (matrix[0, 0]
                    + matrix[0, matrix.GetLength(0) - 1]
                    + matrix[matrix.GetLength(1) - 1, 0]
                    + matrix[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1])
                    / 4.0;
        }
    }
    return mean;
}

const int Rows = 5;
const int Columns = 5;
const int LeftBorder = -10;
const int RightBorder = 10;

double[,] myMatrix = GetRandomMatrix(Rows, Columns, LeftBorder, RightBorder);
PrintMatrix(myMatrix);
double cornersMean = FindMeanOfCornerElements(myMatrix);
Console.WriteLine($"Среднее арифметическое угловых элементов = {cornersMean:F2}");