/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] pic = new int[,]
{
 {0, 0, 0, 0},
 {0, 0, 0, 0},
 {0, 0, 0, 0},
 {0, 0, 0, 0},
};


void Image (int [,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
      for (int j = 0; j < image.GetLength(1); j++)
     {
        Console.Write (image [i,j] + "\t");
     }
    Console.WriteLine();
    }
}

void FillImage1 (int row, int col, int number, int end)
{
    if (pic[row,col] == 0 && col < end)
    {   
        pic [row,col] = number;
        FillImage1 (row, col+1, number+1, end );
    }
}

void FillImage2 (int row, int col, int number, int end)
{
    if (pic[row,col] == 0 && row < end)
    {   
        pic [row,col] = number;
        FillImage2 (row+1, col, number+1, end );
    }
}

void FillImage3 (int row, int col, int number, int end)
{
    if (pic[row,col] == 0 && col > end)
    {   
        pic [row,col] = number;
        FillImage3 (row, col-1, number+1, end );
    }
}

void FillImage4 (int row, int col, int number, int end)
{
    if (pic[row,col] == 0 && row > end)
    {   
        pic [row,col] = number;
        FillImage4 (row-1, col, number+1, end );
    }
}

Image (pic);
FillImage1 (0,0,1,3);
FillImage2 (0,3,4,3);
FillImage3 (3,3,7,0);
FillImage4 (3,0,10,0);
FillImage1 (1,1,13,3);
FillImage2 (2,2,15,3);
FillImage3 (2,1,16,0);
Image (pic);
