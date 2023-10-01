// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки по оси Ox: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Oy: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки по оси Ox: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Oy: ");
int y2 = Convert.ToInt32(Console.ReadLine());

//Расстояние между точками по формуле d = √ (х А – х В) 2 + (у А – у В) 2

double d = ((x1 - x2)*(x1-x2) + (y1 - y2) * (y1 - y2));
Console.WriteLine($"Длина отрезка составляет {Math.Sqrt(d)}");