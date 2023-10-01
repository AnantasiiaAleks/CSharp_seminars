// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int GetInt(string message)
{
    int result;
    Console.Write(message);
    while (!int.TryParse(Console.ReadLine(),out result))
    {
        Console.WriteLine("Ошибка ввода. Введите число");
    }
    return result;
}

void pows (int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}
int number = GetInt("Введите число: ");
pows (number);