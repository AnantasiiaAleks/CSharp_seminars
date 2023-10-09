//Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101, 3 -> 11, 2 -> 10

using System.Globalization;

int GetInt(string message)
{
    Console.Write(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintBinaryView(int a)
{
    if (a <= 0) return;
    PrintBinaryView(a / 2);
    Console.Write(a % 2);
}

int number = GetInt("Привет, дай мне число: ");
PrintBinaryView(number);

// int BinarySize (int a)
// {
//     int binaryLength = 0;
//     for(int i = 0; a > 0; i++)
//     {
//         a /= 2;
//         binaryLength +=1;
//     }
//     return binaryLength;
// }

// int[] BinaryArray (int binaryLength, int a)
// {
//     int[] binaryArray = new int[binaryLength];
//     for(int i = 0; i < binaryArray.Length; i++)
//     {
//         binaryArray[binaryArray.Length - i - 1] = a % 2;
//         a /= 2;
//     }
//     return binaryArray;
// }

// int number = GetInt("Привет, дай мне число: ");
// int arraySize = BinarySize(number);
// int[] binary = BinaryArray(arraySize, number);
// Console.WriteLine("Твое двоичное число готово:");
// Console.WriteLine(string.Join("", binary));