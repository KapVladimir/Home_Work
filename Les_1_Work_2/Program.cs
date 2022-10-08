/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
    Console.WriteLine ("Введите 1-ое число:"); 
    int userNumber1 = Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine ("Введите 2-ое число:"); 
    int userNumber2 = Convert.ToInt32 (Console.ReadLine());

if (userNumber2 == userNumber1)
{ 
    Console.WriteLine ($"Числа равны");
}
if (userNumber2 > userNumber1)
{ 
    Console.WriteLine ($"Число {userNumber2} - максимальное");
    Console.WriteLine ($"Число {userNumber1} - минимальное");
}
if (userNumber2 < userNumber1)
{
    Console.WriteLine ($"Число {userNumber1} - максимальное");
    Console.WriteLine ($"Число {userNumber2} - минимальное");
}