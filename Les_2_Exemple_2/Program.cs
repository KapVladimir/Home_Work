/* Напишите программу, которая принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да */ 

Console.WriteLine ("Введите число");
int userNumber1 = Convert.ToInt32 (Console.ReadLine());

string Kratno (int userNumber1)
{
    string kratno = "";
    if (userNumber1 % 7 == 0 && userNumber1 % 23 ==0)
    {
        kratno = "ДА";
    }
    else kratno = "НЕТ";
    return kratno;
}

Console.WriteLine(userNumber1);
string result = Kratno (userNumber1);
Console.WriteLine (result);