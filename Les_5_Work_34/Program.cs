/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int getCountTwoFromArray (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(100,1000);
        Console.Write ($"{arr [i]} ");
        if (arr[i] % 2 == 0) 
        {
            count = count + 1 ;
        }
    }
    return count;
}
Console.Write ("Введите длину массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());
int [] resultArr = new int [userArray];
Console.Write ("Элементы массива >> ");
int result = getCountTwoFromArray (resultArr);
Console.WriteLine();
Console.Write ($"Количество четных чисел в массиве: {result}");
