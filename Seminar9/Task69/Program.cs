// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень
// B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int PowAinB(int a, int b)           //PowAinB(a, b - 1)
{
    if (b == 0)
    {
        return 1;
    }
    return PowAinB(a, b - 1) * a;
}

int firstNum = GetInt("Дай число: ");
int lastNum = GetInt("Дай число для степени: ");
int result = PowAinB(firstNum, lastNum);
Console.WriteLine(result);