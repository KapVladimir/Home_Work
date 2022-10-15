/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


int [] getUserNumberForArray (int userNumber)
{
    int [] arrayUser = new int[userNumber];
    for (int i = 0; i < userNumber; i++)
    {
        Console.Write ($"Введите число {i+1}: ");
        int UserNumberWrite = Convert.ToInt32 (Console.ReadLine()); 
        arrayUser [i] = UserNumberWrite;
    }
    return arrayUser;
}
int getCountZeroUserNumber (int [] Arra)
{
    int result = 0;
    for (int i = 0; i < Arra.Length; i++)
    {
        if (Arra[i] > 0)
        {
            result +=1;
        }
    }
    return result;
}

Console.Write ("Сколько чисел вы хотете ввести? ");
int UserCountNumber = Convert.ToInt32 (Console.ReadLine());
int [] userArray = getUserNumberForArray (UserCountNumber);
int countZero = getCountZeroUserNumber (userArray);
Console.Write ($"Количество чисел больше 0: {countZero}");

