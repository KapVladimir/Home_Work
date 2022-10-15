/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void getValueTwoLineFromUser(double b1, double k1, double b2, double k2)
{
    
    if (k1==k2)
    {
        Console.Write ($"Линии параллельны");
    }
    else
    {
       Console.Write ($"Точка пересечения линий: ({(b2 -b1)/(k1-k2)};{(b2 -b1)/(k1-k2)}) ");
    }
}
Console.Write ("Введите значение b1: ");
double userNumberB1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите значение k1: ");
double userNumberK1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите значение b2: ");
double userNumberB2 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите значение k2: ");
double userNumberK2 = Convert.ToInt32 (Console.ReadLine());

getValueTwoLineFromUser(userNumberB1, userNumberK1, userNumberB2, userNumberK2);