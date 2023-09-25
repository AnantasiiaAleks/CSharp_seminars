//  Напишите программу, которая принимает на 
//  вход трёхзначное число и 
//  на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number<1000)
{
    Console.WriteLine("result is " + number % 10);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}