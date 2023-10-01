// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координату первой точки по оси Ox: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату первой точки по оси Oy: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату второй точки по оси Ox: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по оси Oy: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// //Расстояние между точками по формуле d = √ (х А – х В) 2 + (у А – у В) 2

// double d = ((x1 - x2)*(x1-x2) + (y1 - y2) * (y1 - y2));
// Console.WriteLine($"Длина отрезка составляет {Math.Sqrt(d)}");

int InputAndCheck(string message)
{
    bool check = false;
    int output = 0;
    while (check != true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        check = int.TryParse(input, out output);
        if (check == false)
        {
            Console.WriteLine("wrong output");
        }
    }
    return output;
}

void Distance(int x1, int x2, int y1, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
    Console.WriteLine($"Длина отрезка составляет: {Math.Round(result, 2)}");
}
Console.Clear();
int x1 = InputAndCheck("enter X1");
int y1 = InputAndCheck("enter y1");
int x2 = InputAndCheck("enter X2");
int y2 = InputAndCheck("enter y2");
Distance (x1, x2, y1, y2);