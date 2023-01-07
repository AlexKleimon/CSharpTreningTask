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
        else Console.WriteLine($"Число {number1} равно чисду {number2}.");
    }
}