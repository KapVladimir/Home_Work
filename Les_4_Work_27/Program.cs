/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getSumFromNumber (int number)
{
    int endPoint = number.ToString().Length;
    int result = 0;
    for (int i = 0; i <= endPoint ; i++)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.Write ("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int resultSum = getSumFromNumber (userNumber);
Console.Write ($"Сумма цифр числа {userNumber} равно: {resultSum}");