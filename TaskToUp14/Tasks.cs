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
    /// <summary>
    ///  Задача 3. По заданному номеру дня недели вывести его название.
    /// </summary>
    public static void Task3()
    {
        Console.WriteLine("Задача 3. По заданному номеру дня недели вывести его название.");
        int number1 = 0;
        while (number1 > 7 || number1 < 1)
        {
            Console.WriteLine("Введите номер дня недели (1...7):");
            number1 = MyMethods.InputNumberInt();
        }
        MyMethods.DayWeek(number1);
    }
    /// <summary>
    /// Задача 4. Найти максимальное из трех чисел.
    /// </summary>
    public static void Task4()
    {
        Console.WriteLine("Задача 4. Найти максимальное из трех чисел.");
        Console.WriteLine("Введите первое число:");
        int number1 = MyMethods.InputNumberInt();
        Console.WriteLine("Введите второе число:");
        int number2 = MyMethods.InputNumberInt();
        Console.WriteLine("Введите третее число:");
        int number3 = MyMethods.InputNumberInt();
        int max = MyMethods.MaxThreeNumbers(number1, number2, number3);
        Console.WriteLine($"Среди трех чисел максимальным является: {max}.");
    }
    /// <summary>
    /// Задача 5. Написать программу вычисления значения функции y = sin(x).
    /// </summary>
    public static void Task5()
    {
        Console.WriteLine("Задача 5. Написать программу вычисления значения функции y = sin(x).");
        Console.WriteLine("Введите значение аргумента функции sin(x):");
        int x = MyMethods.InputNumberInt();
        Console.WriteLine($"Значение функции sin( {x} ) равно {MyMethods.MathSin(x)}.");
    }
    /// <summary>
    /// Задача 6. Выяснить является ли число чётным.
    /// </summary>
    public static void Task6()
    {
        Console.WriteLine("Задача 6. Выяснить является ли число чётным.");
        Console.Write("Введите число: ");
        int number = MyMethods.InputNumberInt();
        MyMethods.ParityCheck(number);
    }
    /// <summary>
    /// Задача 7. Показать числа от -N до N.
    /// </summary>
    public static void Task7()
    {
        Console.WriteLine("Задача 7. Показать числа от -N до N.");
        Console.Write("Введите число N: ");
        int N = MyMethods.InputNumberInt();
        MyMethods.OutputNumbers(N);
    }
    /// <summary>
    /// Задача 8. Показать четные числа от 1 до N.
    /// </summary>
    public static void Task8()
    {
        Console.WriteLine("Задача 8. Показать четные числа от 1 до N.");
        Console.Write("Введите число N:");
        int N = MyMethods.InputNumberInt();
        MyMethods.OutputEvenNumbers(N);
    }
    /// <summary>
    /// Задача 9. Показать последнюю цифру трёхзначного числа.
    /// </summary>
    public static void Task9()
    {
        Console.WriteLine("Задача 9. Показать последнюю цифру трёхзначного числа.");
        Console.Write("Введите трёхзначное число: ");
        int result = MyMethods.InputNumberThreeInt() % 10;
        Console.WriteLine($"Последняя цифра трёхзначного числа: {result}.");
    }
    /// <summary>
    /// Задача 10. Показать вторую цифру трёхзначного числа.
    /// </summary>
    public static void Task10()
    {
        Console.WriteLine("Задача 10. Показать вторую цифру трёхзначного числа.");
        Console.Write("Введите трёхзначное число: ");
        int number = MyMethods.InputNumberThreeInt();
        int result = (number % 100) / 10;
        Console.WriteLine($"Последняя цифра трёхзначного числа: {result}.");
    }
    /// <summary>
    /// Задача 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
    /// </summary>
    public static void Task11()
    {
        Console.WriteLine("Задача 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");
        int number = Random.Shared.Next(10, 100);
        Console.WriteLine("Случайное число из отрезка [10,99]: {0}.", number);
        int oneNumber = number / 10;
        int twoNumber = number % 10;
        MyMethods.MinMaxNumbers(oneNumber, twoNumber);
    }

}