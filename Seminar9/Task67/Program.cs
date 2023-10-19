// Задача 67: Напишите программу, которая будет
// принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int SumDigits(int n)
{
    if (n == 0)
    {
        return 0;
    }
    int sum = 0;
    sum = SumDigits(n / 10) + n % 10;
    return sum;
}

int num = GetInt("Дай число: ");
int sum = SumDigits(num);
Console.WriteLine(sum);