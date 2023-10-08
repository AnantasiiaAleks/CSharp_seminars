// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

int [] ChangeElementsOfArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            array[i] *= -1;
        }
    }
    return array;
}
const int Lenght = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
string myArrayString = string.Join(", ", myArray); //перевод массива в строку
Console.WriteLine(myArrayString);
int[] myChangeArray = ChangeElementsOfArray(myArray);
Console.WriteLine(string.Join(", ", myChangeArray));