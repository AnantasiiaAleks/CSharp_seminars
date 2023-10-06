// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int a)
{
    int sum = 0;
    int i = 0;
     while (a >= 1 || a <= -1)
    {
        sum = sum + (a % 10);
        a /= 10;
        i++;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number != 0)
{
    int result = SumDigits(number);
    Console.WriteLine($"Сумма цифр числа {number} составляет {Math.Abs(result)}");
}
else
{
    Console.WriteLine("Введите число, отличное от нуля");
}

