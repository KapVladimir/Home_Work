/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void getResultFromPolindrom (int userNumber)
{
    int newUser = ((userNumber/10) % 1000);
    if (userNumber/10000 != userNumber % 10) Console.WriteLine ($"ЧИСЛО НЕ ПАЛИНДРОМ");
    else if ((newUser % 10) != (newUser / 100)) Console.WriteLine ($"ЧИСЛО НЕ ПАЛИНДРОМ");
        else Console.WriteLine ($"ЧИСЛО ПАЛИНДРОМ");
}
Console.WriteLine ("Введите число:");
int userNumber1 = Convert.ToInt32 (Console.ReadLine());
getResultFromPolindrom (userNumber1);