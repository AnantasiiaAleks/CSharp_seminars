//Задайте массив. Напишите прорамму, которая определяет,
// присутствует ли заданное число в массиве.
// Пример: 4; массив [4, 7, 19, 345, 3] - нет
// 3; массив [6, 7, 19, 345, 3] - да.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

bool NumberInArray(int a, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            return true;
        }
    } 
    return false;
}

const int Lenght = 10;
const int LeftBorder = 1;
const int RightBorder = 100;

int number = ReadNumber("Введите число: ");
int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
Console.WriteLine(string.Join(", ", myArray));
bool result = NumberInArray(number, myArray);
Console.WriteLine($"{number} - {result}");
