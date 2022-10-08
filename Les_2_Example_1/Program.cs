/* Напишите программу, которая принимает на вход два числа и 
проверяет, является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет */

Console.WriteLine ("Введите первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

string Square (int userNumber1, int userNumber2)
{
    string squareResult = "";
    if (userNumber1 / userNumber2 == userNumber2  || userNumber2 / userNumber1 == userNumber1 )
    {
        squareResult = "ДА";
    }
    else squareResult = "НЕТ";
    return squareResult;
}

String result = Square (userNumber1, userNumber2);
Console.WriteLine (result);
