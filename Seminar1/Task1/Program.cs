// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Да, это так!");
}
else
{
    Console.WriteLine("Нет, вы не правы!");
}