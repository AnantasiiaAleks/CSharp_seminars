// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int AkkermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AkkermanFunc(n - 1, 1);
    }
    else
    {
        return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
    }
}

int firstNum = GetInt("Введите число N: ");
int secondNum = GetInt("Введите число M: ");
int result = AkkermanFunc(firstNum, secondNum);
Console.WriteLine(result);