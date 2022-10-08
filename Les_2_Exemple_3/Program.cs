// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8
int getRandomNumberFromRange (int minBorder, int maxBorder)
{
    int result = new int ();
    result = new Random().Next(minBorder, maxBorder+1);
    return result;
}
int getMaxDigitFromNumber (int number)
{
    int maxDigit = 0;
    while (number > 0)
    {
        int currentDigital = number %10;
        if (maxDigit < currentDigital)
        {
        maxDigit = currentDigital;
        }
        number = number /10;
        Console.WriteLine ($"12 {maxDigit}");
    }
    
    return maxDigit;
}
int getMaxDigitFromNumberOfTwo (int number)
{
    int maxDigital = number %10;
    int secondDigit = number/10;
    if (maxDigital < secondDigit)
        {
        maxDigital = secondDigit;
        }
    return maxDigital;
}
int randomNumber = getRandomNumberFromRange (100,999);
Console.WriteLine ($"Случайное число {randomNumber}");
int maxDigit = getMaxDigitFromNumber(randomNumber);
Console.WriteLine ($"Для числа {randomNumber} большая цифра {maxDigit}");

int randomNumber1 = getRandomNumberFromRange (100,999);
int maxDigital = getMaxDigitFromNumberOfTwo (randomNumber1);
Console.WriteLine ($"Для числа {randomNumber1} большая цифра {maxDigital}");