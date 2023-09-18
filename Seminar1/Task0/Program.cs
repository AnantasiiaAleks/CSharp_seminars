// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
string numberString = Console.ReadLine();
// "123" -> 123
int numberInt = Convert.ToInt32(numberString);
int result = numberInt * numberInt;
Console.WriteLine(result);