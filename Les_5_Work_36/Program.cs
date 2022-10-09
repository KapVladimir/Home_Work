/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int getSumTwoFromArray (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr [i] = new Random().Next(-100,100);
        Console.Write ($"{arr [i]} ");
        if (i % 2 > 0) 
        {
            count = count + arr[i] ;
        }
    }
    return count;
}
Console.Write ("Введите длину массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());
int [] resultArr = new int [userArray];
Console.Write ("Элементы массива >> ");
int result = getSumTwoFromArray (resultArr);
Console.WriteLine();
Console.Write ($"Сумма элементов, стоящих на нечетных позициях: {result}");