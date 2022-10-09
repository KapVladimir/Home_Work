/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int GetQuaterFromCoordinate (int coordinateX, int coordinateY)
{
    int result = 0;
    if (coordinateX>0 && coordinateY>0) result = 1;
    else if (coordinateX<0 && coordinateY>0) result = 2;
        else if (coordinateX<0 && coordinateY<0) result = 3;
            else if (coordinateX>0 && coordinateY<0) result = 4;
    return result;
}

int getCoordinateFromUser (string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.WriteLine (userInformation);
        string userLine = Console.ReadLine();
        int.TryParse (userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine ($"Введите целое число, вы ввели {userLine}");
        }
        else break;
    }
    return result;
}

int UsercoordinateX = 0;
int UsercoordinateY =0;
UsercoordinateX = getCoordinateFromUser ("Введите координату X");
UsercoordinateY = getCoordinateFromUser ("Введите координату X");
int otvet = GetQuaterFromCoordinate (UsercoordinateX, UsercoordinateY);
if (otvet>0) Console.WriteLine($"Для кооринат X: {UsercoordinateX}  Y:  {UsercoordinateY}  Номер четверти: {otvet}");
else Console.WriteLine($"Одна из координат нулевая");
