// Задача 30: Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и единицами
// в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// array[0] = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i] + " ");
// } 

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(0, 2);
        Console.Write(array[index] + " ");
    }
    return array;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
FillArray(size);

