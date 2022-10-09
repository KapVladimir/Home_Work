/*

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

double getLineFromTwoPoint (int point1X,int point1Y,int point1Z, int point2X,int point2Y, int point2Z)
{
    double xLength = 0;
    if (point1X > point2X) xLength = point1X-point2X;
        else xLength = point2X - point1X;
    
    double yLength = 0;
    if (point1Y > point2Y) yLength = point1Y-point2Y;
        else yLength = point2Y - point1Y;  

    double zLength = 0;
    if (point1Z > point2Z) zLength = point1Z-point2Z;
        else zLength = point2Z - point1Z;  
    
    double result = 0;
    return result = Math.Sqrt (Math.Pow(xLength,2) + Math.Pow(yLength,2) + Math.Pow(zLength,2));
}

Console.WriteLine ("Введите точку 1, Х:");
int userPoint1X = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 1, Y:");
int userPoint1Y = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 1, Z:");
int userPoint1Z = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 2, Х:");
int userPoint2X = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 2, Y:");
int userPoint2Y = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 2, Z:");
int userPoint2Z = Convert.ToInt32 (Console.ReadLine());

double otvet = getLineFromTwoPoint (userPoint1X,userPoint1Y,userPoint1Z,userPoint2X, userPoint2Y, userPoint2Z);
Console.WriteLine (otvet);