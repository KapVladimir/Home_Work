    Console.WriteLine ("Введите число А");
 int userNumber1 = Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine ("Введите число В");
 int userNumber2 = Convert.ToInt32 (Console.ReadLine());

 int result = userNumber2 / userNumber1;
 if  (result == userNumber1)
 { 
    Console.WriteLine ($"Число {userNumber1} является корнем {userNumber2}");
 }

 else
 {
 Console.WriteLine($"Число {userNumber1} не является корнем {userNumber2}");
 }
