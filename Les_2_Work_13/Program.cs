/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine ("Введите число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

int GetNumber (int userNumber1)
{   
    int newNumber = userNumber1;
    int newSet =0 ;
     int newResult =0 ;
    for (int i = 0; i < 2; i++)
    {
        newNumber = newNumber / 10;
        if (i==2);
        newSet = (newNumber% 10);
    }

    if (newSet > 0)
    {newResult = newSet;
    }
    else
    if (newSet==0 && userNumber1 > 999)
    {newResult = newSet;
    }
    else
    newResult = -1;
    
    return (newResult);
}


int result = GetNumber (userNumber1);

if (result >= 0)
{Console.WriteLine ($"ТРЕТЬЕ ЧИСЛО {result}");
}
else
Console.WriteLine ($"НЕТ ТРЕТЬЕГО ЧИСЛА");

