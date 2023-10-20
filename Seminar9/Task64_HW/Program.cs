// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System.Runtime.CompilerServices;

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void FromNToOne(int n, int cur)
{
    if (cur > n)
        {
            return;
        }
        FromNToOne(n, cur + 1);
        Console.WriteLine(cur);
}

int num = GetInt("Дай число: ");
int current = 1;
FromNToOne(num, current);