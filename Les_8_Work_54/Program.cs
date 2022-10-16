/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
void getArraySetCourse (int [,] arra)
{
        for (int i = 0; i < arra.GetLength(0); i++)
        {
            int maxPosition = 0;
            for (int j = 0; j < arra.GetLength(1); j++)
            { 
                maxPosition = j;
                 for (int k = j+1; k < arra.GetLength(1); k++)
                {
                    if(arra [i,k] > arra [i,maxPosition]) 
                    {
                        maxPosition = k;
                    }
                }
                int temp = arra [i,j];
                arra [i,j] = arra [i,maxPosition];
                arra [i,maxPosition] = temp;
                Console.Write (arra [i, j] + "\t");
            } 
        Console.WriteLine();
        }
}
Console.WriteLine("------------------Исходный массив--------------------");
int [,] generatedArray = generateArray (5,4);
PrintArray (generatedArray);
Console.WriteLine();
Console.WriteLine("---------------Отсортированный массив-----------------");
getArraySetCourse (generatedArray);
