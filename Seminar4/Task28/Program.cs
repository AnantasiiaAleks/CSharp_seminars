// Задача 28: Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}

int number = GetNumber("Введите целое положительное число: ");
if (number >= 1)
{
    int result = Factorial(number);
    Console.WriteLine($"произведение чисел от 1 до {number} = {result}");
}