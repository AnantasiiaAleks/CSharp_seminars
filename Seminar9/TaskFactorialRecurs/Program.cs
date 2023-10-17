// Задача:
// при помощи рекурсии вывести факториал числа N.

const uint N = 4;   //uint - целое число, которое может быть только положительным

uint Factorial(uint n)
{
    if(n == 0 || n == 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

uint result = Factorial(N);
Console.WriteLine(result);