/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4

индексы:
[0.0][0.1][0.2][0.3]
 1     4    7    2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4/*

*/
int [,] generateArray (int hight, int weight)
{
    int [,] generatedArray = new int [hight,weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {   
            generatedArray[i,j] = new Random().Next (-100, 100);
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

string getPozitionFromArray (int [,] arra, int userNumberPozition)
{
    int resulti = 0;
    int result = 0;
    if (((arra.GetLength(0) +1) * (arra.GetLength(1)+1)) > userNumberPozition)
    {
        for (int i = 0; i < arra.GetLength(0); i++)
        {
            for (int j = 0; j < arra.GetLength(1); j++)
            {
                if (userNumberPozition == resulti)
                {
                    result = arra [i, j];
                }
                resulti +=1;
            }
        }
        return ($"Число позиции: {result}");
    }
    else
    {
        return ($"Такой позиции в массиве НЕТ"); 
    }
}

int [,] generatedArray = generateArray (3,4);
PrintArray (generatedArray);

Console.Write ("Введите номер позиции: ");
int userNumberK2 = Convert.ToInt32 (Console.ReadLine());

string result = getPozitionFromArray (generatedArray, userNumberK2);
Console.Write (result);
