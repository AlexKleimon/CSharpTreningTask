class MyMethods
{
    /// <summary>
    /// Метод ввода числового значения в консоль.
    /// </summary>
    /// <returns>Числовое значение типа int.</returns>
    public static int InputNumberInt()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
    /// <summary>
    /// Метод возведения целого числа в квадрат.
    /// </summary>
    /// <param name="number">Число типа int, необходимое возвести в квадрат.</param>
    /// <returns>Квадрат числа.</returns>
    public static int SquareNumber(int number)
    {
        return number * number;
    }
    /// <summary>
    /// Метод проверяет, является ли первое число квадратом второго.
    /// </summary>
    /// <param name="number1">Первое число.</param>
    /// <param name="number2">Второе число.</param>
    public static void ChekingSquareNumber(int number1, int number2)
    {
        if (number1 == number2 * number2)
            Console.WriteLine($"Число {number1} является квадратом числа {number2}.");
        else Console.WriteLine($"Число {number1} не является квадратом числа {number2}.");
    }
    /// <summary>
    /// Метод сравнения чисел типа int.
    /// </summary>
    /// <param name="number1">Первое число.</param>
    /// <param name="number2">Второе число.</param>
    public static void MinMaxNumbers(int number1, int number2)
    {
        if (number1 > number2) Console.WriteLine($"Число {number1} является максимальным, а число {number2} минимальным.");
        else if (number1 < number2) Console.WriteLine($"Число {number2} является максимальным, а число {number1} минимальным.");
        else Console.WriteLine($"Число {number1} равно числу {number2}.");
    }
    /// <summary>
    /// Метод определения по номеру название дня недели.
    /// </summary>
    /// <param name="numberDay">Номер дня недели.</param>
    public static void DayWeek(int numberDay)
    {
        if (numberDay == 1) Console.WriteLine($"День недели под номером {numberDay}: понедельник.");
        else if (numberDay == 2) Console.WriteLine($"День недели под номером {numberDay}: вторник.");
        else if (numberDay == 3) Console.WriteLine($"День недели под номером {numberDay}: среда.");
        else if (numberDay == 4) Console.WriteLine($"День недели под номером {numberDay}: четверг.");
        else if (numberDay == 5) Console.WriteLine($"День недели под номером {numberDay}: пятница.");
        else if (numberDay == 6) Console.WriteLine($"День недели под номером {numberDay}: суббота.");
        else Console.WriteLine($"День недели под номером {numberDay}: Воскресенье.");
    }
}