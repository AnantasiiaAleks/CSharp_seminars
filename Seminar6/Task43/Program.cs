// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

int GetInt(string message)
{
    Console.Write(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

double[] LineValue(int numberOfLine)
{
    double[] lineCoords = new double[2];
    lineCoords[0] = GetInt($"Дай мне коэффициент для прямой {numberOfLine}: ");
    lineCoords[1] = GetInt($"Дай мне пересечение прямых с осью y для прямой {numberOfLine}: ");
    return lineCoords;
}

bool LineValidation (double[] line1Coords, double[] line2Coords)
{
    if (line1Coords[0] == line2Coords[0])
    {
        if (line1Coords[1] == line2Coords[1])
        {
            Console.WriteLine("Прямые совпадают. Ничего не выйдет.");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны. Ничего не выйдет.");
            return false;
        }
    }
    else
    {
        return true;
    }
}


double[] FindPoint (double[] line1Coords, double[] line2Coords)
{
    double[] point = new double[2];
    point[0] = (line2Coords[1] - line1Coords[1]) / (line1Coords[0] - line2Coords[0]);
    point[1] = line1Coords[0] * point[0] + line1Coords[1];
    return point;
}

const int Line1 = 1;
const int Line2 = 2;

double[] line1Data = LineValue(Line1);
double[] line2Data = LineValue(Line2);

if (LineValidation(line1Data, line2Data))
{
    double[] pointCoord = FindPoint (line1Data, line2Data);
    Console.Write($"Координаты точки пересечения двух прямых с уравнениями у={line1Data[0]}*x+{line1Data[1]} и y={line2Data[0]}*x+{line2Data[1]}");
    Console.WriteLine($"- [{pointCoord[0]}, {pointCoord[1]}]");
}