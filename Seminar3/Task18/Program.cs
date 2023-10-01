// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек
// в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("Координаты точек по оси OX > 0, координаты точек по оси OY > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("Координаты точек по оси OX < 0, координаты точек по оси OY > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("Координаты точек по оси OX < 0, координаты точек по оси OY < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("Координаты точек по оси OX > 0, координаты точек по оси OY < 0");
}
else
{
    Console.WriteLine("Координаты определить невозможно");
}