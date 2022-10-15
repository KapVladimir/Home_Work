/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] generateArray (int hight, int weight)
{
    double [,] generatedArray = new double [hight,weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {   
            generatedArray[i,j] = new Random().Next (-100, 100);
        }
    }
    return generatedArray;

}
void PrintArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
     {
         Console.Write (matrix [i, j]/10 + "\t");
     }
    Console.WriteLine();
    }
}

double [,] generatedArray = generateArray (3,4);
PrintArray (generatedArray);

