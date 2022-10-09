/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

void getNumberForArray (int [] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr [i] = new Random().Next(1,99);
        Console.Write ($"{arr [i]} ");
    }
}

Console.Write ("Введите длину массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());
int [] resultArr = new int [userArray];
Console.WriteLine();
Console.Write ("Элементы массива >> ");
getNumberForArray (resultArr);
