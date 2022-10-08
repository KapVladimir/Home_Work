/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 16, 4 -> кратно
*/

Console.WriteLine ("Введите первое число:");
int userNumber1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите второе число:");
int userNumber2= Convert.ToInt32 (Console.ReadLine());


void GetKratFromTwoDigitNumer (int userNumber1, int userNumber2 )

{
    if (userNumber1 % userNumber2 == 0)
    {
    Console.WriteLine ($"{userNumber1} кратное {userNumber2}");
    }
    else Console.WriteLine ($"{userNumber1} не кратное {userNumber2} остаток {userNumber1 % userNumber2}");
}

GetKratFromTwoDigitNumer (userNumber1, userNumber2 );
