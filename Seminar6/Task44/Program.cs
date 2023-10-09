//Не используя рекурсию, выведите первые N чисел
//последовательности чисел Фибоначчи.
//Первые два числа Фибоначчи 0 и 1
//N = 5 -> 0 1 1 2 3
//N = 3 -> 0 1 1
//N = 7 -> 0 1 1 2 3 5 8

int GetInt(string message)
{
    Console.Write(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[] Fibonacci (int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

int number = GetInt("Привет, дай мне число: ");
int[] fibonacci = Fibonacci(number);
Console.WriteLine($"Последовательность Фибоначчи до {number} готова:");
Console.WriteLine(string.Join(", ", fibonacci));