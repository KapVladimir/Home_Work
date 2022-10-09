/* Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). */


string GetQuaterFromCoordinate (int chetvert)
{
    string result = string.Empty;
    if (chetvert == 1) result = "координаты X>0, Y>0";
    else if (chetvert == 2) result = "координаты X<0, Y>0";
        else if (chetvert == 3) result = "координаты X<0, Y<0";
            else if (chetvert == 4) result = "координаты X>0, Y<0";
                else result = "Введено не корректное значение четверти";
    return result;
}
Console.WriteLine ("Введите номер четверти");
int chetvert = Convert.ToInt32 (Console.ReadLine());
string otvet = GetQuaterFromCoordinate (chetvert);
Console.WriteLine (otvet);