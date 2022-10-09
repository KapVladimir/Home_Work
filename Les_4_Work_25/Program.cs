/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int getDigitExponent (int digite, int exponent)
{
    int result = 1;
    for (int i = 1; i <= exponent; i++)
    {
        result = result * digite;
    }
    return result;
}

Console.Write ("Введите число:");
int userDigite = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите степень:");
int userExponent = Convert.ToInt32(Console.ReadLine());
int resultExponent = getDigitExponent (userDigite, userExponent);
Console.Write ($"Число {userDigite} в степени {userExponent}, равно: {resultExponent}");
