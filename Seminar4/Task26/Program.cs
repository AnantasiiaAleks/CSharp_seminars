// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 1) принимает на вход число

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// 2) считает количество цифр в числе

int CountDigits(int a)
{
    int i = 0;
    while (a > 1 || a < -1)
    {
        a /= 10;
        i++;
    }
    return i;
}

int number = ReadNumber("Введите число: ");
if (number != 0)
{
    int count = CountDigits(number);
    Console.WriteLine($"Количество цифр числа {number} - {count}");
}
else
{
    Console.WriteLine("Введите число отличное от нуля");
}