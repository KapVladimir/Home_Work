
/*
задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 
*/

double getLineFromTwoPoint (int point1X,int point1Y,int point2X,int point2Y)
{
    double xLength = 0;
    if (point1X > point2X) xLength = point1X-point2X;
        else xLength = point2X - point1X;
    
    double yLength = 0;
    if (point1Y > point2Y) yLength = point1Y-point2Y;
        else yLength = point2Y - point1Y;  
    
    double result = 0;
    return result = Math.Sqrt (xLength*xLength + yLength*yLength);
}

Console.WriteLine ("Введите точку 1, Х:");
int userPoint1X = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 1, Y:");
int userPoint1Y = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 2, Х:");
int userPoint2X = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите точку 2, Y:");
int userPoint2Y = Convert.ToInt32 (Console.ReadLine());
double otvet = getLineFromTwoPoint (userPoint1X,userPoint1Y,userPoint2X, userPoint2Y);
Console.WriteLine (otvet);