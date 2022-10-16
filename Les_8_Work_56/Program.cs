/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int getMinResultSecondStringFromArray (int [,] arra)
{    int resultOneString = 0;
    for (int j = 0; j < arra.GetLength(1); j++)
         {
            resultOneString = resultOneString + arra[0,j];
        }
    return resultOneString;
}

int getMinResultStringFromArray (int [,] arra, int valueSecondString)
{    
    int minString = 1; 
    
     for (int i = 0; i < arra.GetLength(0); i++)
        {
            int result = 0; 
            for (int j = 0; j < arra.GetLength(1); j++)
            {
                result = result + arra[i,j];            
            }
            Console.WriteLine($"Строка {i+1} сумма равна: {result}");
            if (result < valueSecondString)
            {
                minString = i+1;
                valueSecondString = result;
            }
        }
    return minString;
}

int [,] generatedArray = generateArray (4,4);
PrintArray (generatedArray);
int resultSecondMin = getMinResultSecondStringFromArray (generatedArray);
int resultArraydMin = getMinResultStringFromArray (generatedArray,resultSecondMin);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов - это строка {resultArraydMin}");
Console.WriteLine();