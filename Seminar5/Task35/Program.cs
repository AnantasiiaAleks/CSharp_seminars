// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]
// Пример: [5,18,123,6,2,...] -> 1

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

int CountRelateNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

const int Lenght = 123;
const int LeftBorder = 1;
const int RightBorder = 200;
int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
Console.WriteLine(string.Join(", ", myArray));
int count = CountRelateNumber(myArray);
Console.WriteLine($"В массиве встречается {count} числа из промежутка от 10 до 99");