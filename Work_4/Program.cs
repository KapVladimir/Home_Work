/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine ("Введите 1-ое число:"); 
int userNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите 2-ое число:");
int UserNumber1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите 3-е число:");
int UserNumber2 = Convert.ToInt32 (Console.ReadLine());

int result = userNumber;
if (result < UserNumber1) result = UserNumber1;
if (result < UserNumber2) result = UserNumber2;

Console.WriteLine ($"Число {result} - максимальное");  
