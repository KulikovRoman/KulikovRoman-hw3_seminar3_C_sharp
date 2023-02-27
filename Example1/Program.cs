// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int InputInt(string message)
{
    System.Console.Write($"{message}> ");
    if (int.TryParse(Console.ReadLine(), out int value) && value >= 1)
    {
        return value;
    }
    System.Console.WriteLine("Пожалуйста введите положительное число больше ноля");
    Environment.Exit(1);
    return 0;
}

int userNumber = InputInt($"Введите число для определения является ли оно полиндромом");

int LengthNumber(int userNumber)
{
    int double1UserNumber = userNumber;
    int divider = 10;
    int lengthСounter = 0;
    while (double1UserNumber > 0)
    {
        double1UserNumber = double1UserNumber / divider;
        lengthСounter++;
    }
    return lengthСounter;
    
}

int lengthNumber = LengthNumber(userNumber);
//System.Console.WriteLine(lengthNumber);

//string Palindrome(int answer)
//{
    int double2UserNumber = userNumber;
    double a = 0;
    double b = 0;
    //int degreeА = lengthNumber-1;
    //int degreeB = 1;
    double dividerA = Math.Pow(10, lengthNumber-1);
    double dividerB = Math.Pow(10, 1);
    int middleUserNumber = lengthNumber / 2;
    while (a <= middleUserNumber)
    {
        a = double2UserNumber / dividerA;
        b = double2UserNumber % dividerB;
        if (a == b)
        {
            dividerA = dividerA / 10;
            dividerB = dividerB * 10;
            System.Console.Write($"Полиндром");
        }
        else
        {
            System.Console.Write($"Не полиндром");
        }
    }
    
    //return Convert.ToString;
//}

//string unswer = Palindrome(userNumber);

//System.Console.WriteLine($"Число {userNumber} {unswer}");

