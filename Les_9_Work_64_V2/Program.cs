/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void printNumber (int userM, int userN )
{
    if (userM == userN)
    {
        Console.Write ($"{userM}");
        return;
    }
    Console.Write ($"{userM}, ");
    printNumber (userM+1,userN);

}
Console.Write("Введите число M: ");
int userNumberM=Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberN=Convert.ToInt32 (Console.ReadLine());
Console.Write("Массив натуральных чисел: ");
printNumber (userNumberM,userNumberN);