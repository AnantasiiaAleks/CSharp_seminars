//Напишите программу, которая перевернет
//одномерный массив (последний элемент будет
//на первом месте, а первый на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder + 1);
    }

    return array;
}

void ReverceArray(int[] sourceArray)
{
    for(int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

const int Lenght = 9;
const int LeftBorder = -10;
const int RightBorder = 10;
int[] myArray = GetRandomArray(Lenght, LeftBorder, RightBorder);
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine();
ReverceArray(myArray);
Console.WriteLine(string.Join(", ", myArray));