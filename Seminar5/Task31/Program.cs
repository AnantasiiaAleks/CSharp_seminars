// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Пример: [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// Сумма положительных чисел равна 29, сумма отрицательных -20.

int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

int SumPositiveElementsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int SumNegativeElementsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

const int Lenght = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
string myArrayString = string.Join(", ", myArray); //перевод массива в строку
Console.WriteLine(myArrayString);

int sumPositive = SumPositiveElementsOfArray(myArray);
int sumNegative = SumNegativeElementsOfArray(myArray);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}, отрицательных = {sumNegative}");