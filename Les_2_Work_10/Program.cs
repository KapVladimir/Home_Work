/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/
    Console.WriteLine ("Введите 3х значное число:"); 
    int userNumber = Convert.ToInt32 (Console.ReadLine());

int GetTwoDigitFromNumber (int userNumber)
{
    int number = userNumber / 10;
    return (number % 10);
}

int result = GetTwoDigitFromNumber (userNumber);
Console.WriteLine (result);