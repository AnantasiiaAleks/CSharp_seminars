// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int a, int b)
{
    int powNum = 1;
    for (int i = 0; i < b; i++)
    {
        powNum *= a;
    }
    return powNum;
}

int number1 = ReadNumber("Введите первое число: ");
int number2 = ReadNumber("Введите второе число: ");
int result = Pow(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {result}");