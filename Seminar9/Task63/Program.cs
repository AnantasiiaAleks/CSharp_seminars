// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1,2,3,4,5"

int GetInt(string message)
{
    Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void OneToN(int n)
{
    if (n == 0)
    {
        return;
    }
    OneToN(n - 1);
    Console.WriteLine(n);
}

int num = GetInt("Дай число: ");
OneToN(num);