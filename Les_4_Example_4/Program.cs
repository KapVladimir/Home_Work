/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int getSumNumber (int startPoint, int endPoint)
{
    int result = 0;
    if (startPoint>endPoint)
    {
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}

Console.Write ("Введите число: ");
int userEndPoint = Convert.ToInt32 (Console.ReadLine());
int resultFunction = getSumNumber (1, userEndPoint);
Console.Write ($"Сумма чисел от 1 до {userEndPoint} равна: {resultFunction}");
