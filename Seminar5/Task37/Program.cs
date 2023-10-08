// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
// Пример: [1 2 3 4 5] -> [5 8 3]
//[6 7 3 6] -> [36 21]

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] newArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
        if (array[i] == array[array.Length - i - 1])
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

const int Lenght = 11;
const int LeftBorder = 1;
const int RightBorder = 10;
int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
Console.WriteLine(string.Join(", ", myArray));
int[] newMyArray = NewArray(myArray);
Console.WriteLine(string.Join(", ", newMyArray));