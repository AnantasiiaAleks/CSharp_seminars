// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от М до N.


int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void MToN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    MToN(m, n - 1);
    Console.WriteLine(n);
}

int firstNum = GetInt("Дай первое число: ");
int lastNum = GetInt("Дай второе число: ");
MToN(firstNum, lastNum);