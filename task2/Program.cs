// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите число k1:");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите число k2:");
double k2 = double.Parse(Console.ReadLine());
GetCoor(b1,k1,b2,k2);
void GetCoor(double xa, double ya, double xb, double yb)
{
    if (xa == xb && ya == yb) 
    {
        Console.Write($"Прямые совпадают");
    }
    else if (xa == xb ^ ya == yb) 
    { 
        Console.Write($"Прямые параллельны");
    }
    else 
    { 
        double X = 0;
        double Y = 0;
        X = (-xb + xa) / (-ya + yb);
        Y = (yb * X) + xb;
        Console.WriteLine($"[{X};{Y}]");
    }  
} 
