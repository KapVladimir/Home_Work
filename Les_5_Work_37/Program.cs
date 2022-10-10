/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int [] getRandomArray (int lenght, int startPoint, int endPoint)
{
    int [] resultArray = new int [lenght];
    for (int i = 0; i < lenght; i++)
    {
      resultArray [i] = new Random().Next(startPoint,endPoint+1);
    }
    return resultArray;
}
void PrintArray (int [] incomongArray)
{
    Console.Write("[");
    for (int i = 0; i < incomongArray.Length; i++)
    {
        Console.Write (incomongArray[i]);
        if ( i< incomongArray.Length-1)
        {
            Console.Write(",");
        }
     }
    Console.Write("]");
}

int [] getMultInArray( int[] incomongNewArray)
{
    if (incomongNewArray.Length % 2 == 0)
    {
    int count = incomongNewArray.Length - 1;
    int oldCount = incomongNewArray.Length/2;
    int [] resultArray = new int [oldCount];
    for (int i = 0; i < oldCount; i++)
    {
        resultArray [i] = incomongNewArray[i] * incomongNewArray[count];
        count = count -1;
    }
    return resultArray;
    }
    else
    {
    int count = incomongNewArray.Length - 1;
    int oldCount = incomongNewArray.Length/2+1;
    int [] resultArray = new int [oldCount];
    for (int i = 0; i < oldCount; i++)
    {
        if (i < oldCount-1)
        {
            resultArray [i] = incomongNewArray[i]*incomongNewArray[count];
        }
        else 
        {
            resultArray [i] = incomongNewArray[incomongNewArray.Length/2];
        }
        count = count -1;
    }
    return resultArray;
    }
    
}

Console.Write ("Введите длину массива: ");
int userArray = Convert.ToInt32(Console.ReadLine());

int [] currentArray = getRandomArray(userArray,1,10);
Console.Write ($"Пользовательский массив: ");
PrintArray (currentArray);
Console.WriteLine ();
int [] currentMultArray = getMultInArray(currentArray);

Console.Write ($"Новый массив, произведений пар : ");
PrintArray (currentMultArray);