/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

string getMinMaxMinusFromArray (double [] arr)
{
        double minNumber = 1000;
        double maxNumber = 0;
   for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(1,1000);
        Console.Write ($"{arr [i]/10} ");
        if (maxNumber > arr [i]/10)
        {
            if (minNumber > arr [i]/10)
            {
                minNumber = arr [i]/10;
            }
        }
        else
        {
            maxNumber = arr [i]/10;
        }
    }
    return ($"-Минимальный элемент массива: {minNumber} \n-Максимальный элемент массива: {maxNumber} \nРазница между элементами: {maxNumber - minNumber,0:F1}");
}
Console.Write ("Введите длину массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());
double [] resultArr = new double [userArray];
Console.Write ("Элементы массива >> ");
string result = getMinMaxMinusFromArray (resultArr);
Console.WriteLine();
Console.Write (result);