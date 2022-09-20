/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа: ");
for(int i = 0; i <= userNumber; i=i+2) 
{
if (i > 0) Console.WriteLine(i);
}