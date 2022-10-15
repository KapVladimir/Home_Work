/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


int getCountUserNumber (int userNumber)
{
    int result = 0;
    for (int i = 0; i < userNumber; i++)
    {
        Console.Write ($"Введите число {i+1}: ");
        int UserNumberWrite = Convert.ToInt32 (Console.ReadLine()); 

        if (UserNumberWrite > 0)
        {
            result = result + 1;
        }
    }
    return result;
}

Console.Write ("Сколько чисел вы хотете ввести? ");
int UserCountNumber = Convert.ToInt32 (Console.ReadLine());
int countZero = getCountUserNumber (UserCountNumber);
Console.Write ($"Количество нулевых значений: {countZero}");

