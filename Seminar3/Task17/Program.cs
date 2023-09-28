// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите координату точки по оси Ox");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по оси Oy");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной плоскости");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной плоскости");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной плоскости");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной плоскости");
}
else
{
    Console.WriteLine("Невозможно определить");
}