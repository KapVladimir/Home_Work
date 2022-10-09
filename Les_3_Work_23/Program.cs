/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void tableFromDigit (int userNumber)
{
    int [] array = new int[userNumber];
    int count = userNumber;
    for (int i = 1; i < userNumber+1; i++)
    {
        Console.WriteLine ($"{Math.Pow(i,3)}");
    }
    Console.WriteLine();    
} 

Console.WriteLine ("Введите N:");
int userNumber1 = Convert.ToInt32 (Console.ReadLine());
tableFromDigit (userNumber1);