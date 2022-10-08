/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine ("Введите день недели (цифрой)");
int userNumberWeek = Convert.ToInt32 (Console.ReadLine());

string GetNumberWeek (int userNumberWeek)
{
    string resultString;
    if (userNumberWeek == 6 || userNumberWeek == 7)
    {resultString = "Выходной день";
    }
    else resultString = "Будний день";
    return resultString;
}

string result = GetNumberWeek (userNumberWeek);
Console.WriteLine (result);