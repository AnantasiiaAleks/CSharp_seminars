// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int SumMToN(int m, int n)
{
    int sum = m;
    if (m > n)
    {
        return 0;
    }
    sum = sum + SumMToN(m + 1, n);
    return sum;
}

int firstNum = GetInt("Дай первое число: ");
int lastNum = GetInt("Дай второе число: ");
int result = SumMToN(firstNum, lastNum);
Console.WriteLine(result);