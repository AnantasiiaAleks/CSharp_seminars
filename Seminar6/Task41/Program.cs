// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetInt(string message)
{
    Console.Write(message);
    int m = Convert.ToInt32(Console.ReadLine());
    return m;
}

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = GetInt($"Введите элемент №{i + 1}: ");
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int size = GetInt("Привет, напиши сколько чисел ты будешь вводить: ");
int[] yourArray = GetArray(size);
Console.WriteLine("Твоя последовательность готова:");
Console.WriteLine(string.Join(", ", yourArray));
int positiveDigits = CountPositive(yourArray);
Console.WriteLine($"Ты ввел {positiveDigits} чисел больше 0");

