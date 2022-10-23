/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void printSumNumber (int userM, int userN, int sumNumber)
{
    if (userM == userN)
    {
        sumNumber += userM;
        Console.Write ($"{sumNumber}");
        return;
    }
    sumNumber += userM;
    printSumNumber (userM+1,userN,sumNumber);

}
Console.Write("Введите число M: ");
int userNumberM=Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberN=Convert.ToInt32 (Console.ReadLine());
Console.Write("Сумма натуральных чисел: ");
printSumNumber (userNumberM,userNumberN,0);