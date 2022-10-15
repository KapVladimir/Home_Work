/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] generateArray (int hight, int weight)
{
    int [,] generatedArray = new int [hight,weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {   
            generatedArray[i,j] = new Random().Next (10, 100);
        }
    }
    return generatedArray;
}
void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
     {
         Console.Write (matrix [i, j] + "\t");
     }
    Console.WriteLine();
    }
}
void getPozitionFromArray (int [,] arra)
{
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            double result = 0;
            for (int i = 0; i < arra.GetLength(0); i++)
            {
                result = result+arra[i,j];
            }
        Console.Write ($"Столбец {j+1}: {result/(arra.GetLength(0)),0:F1}"); 
        Console.WriteLine();
        }
}
int [,] generatedArray = generateArray (3,4);
PrintArray (generatedArray);
getPozitionFromArray (generatedArray);