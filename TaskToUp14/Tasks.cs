class Tasks
{
    /// <summary>
    /// Задача 0. Вывести квадрат числа.
    /// </summary>
    public static void Task0()
    {
        Console.WriteLine("Задача 0. Вывести квадрат числа.");
        Console.WriteLine("Введите число, которое необходимо возвести в квадрат:");
        int number = MyMethods.InputNumberInt();
        Console.WriteLine($"Квадрат числа {number} равен: {MyMethods.SquareNumber(number)}.");
    }
    /// <summary>
    /// Задача 1. По двум заданным числам проверять является ли первое квадратом второго.
    /// </summary>
    public static void Task1()
    {
        Console.WriteLine("Задача 1. По двум заданным числам проверять является ли первое квадратом второго.");
        Console.WriteLine("Введите первое число:");
        int number1 = MyMethods.InputNumberInt();
        Console.WriteLine("Введите второе число:");
        int number2 = MyMethods.InputNumberInt();
        MyMethods.ChekingSquareNumber(number1, number2);
    }
    /// <summary>
    ///  Задача 2. Даны два числа. Показать большее и меньшее число.
    /// </summary>
    public static void Task2()
    {
        Console.WriteLine("Задача 2. Даны два числа. Показать большее и меньшее число.");
        Console.WriteLine("Введите первое число:");
        int number1 = MyMethods.InputNumberInt();
        Console.WriteLine("Введите второе число:");
        int number2 = MyMethods.InputNumberInt();
        MyMethods.MinMaxNumbers(number1, number2);
    }

}