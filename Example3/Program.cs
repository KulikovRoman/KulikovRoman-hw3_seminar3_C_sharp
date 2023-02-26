// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

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

int userNumber = InputInt($"Введите число, для которого выдадим кубы всех значений");

for (int i = 1; i <= userNumber; i++)
{
        System.Console.Write($"{Math.Pow(i, 3)} ");
}
