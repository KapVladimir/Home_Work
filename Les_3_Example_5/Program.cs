/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

void tableFromDigit (int userNumber)
{
    int [] array = new int[userNumber];
    int count = userNumber;
    for (int i = 1; i < userNumber+1; i++)
    {
        Console.WriteLine ($"{Math.Pow(i,2)}");
    }
    Console.WriteLine();    
} 

Console.WriteLine ("Введите N:");
int userNumber1 = Convert.ToInt32 (Console.ReadLine());
tableFromDigit (userNumber1);
