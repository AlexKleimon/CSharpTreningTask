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
    /// <summary>
    /// Метод поиска максимального числа типа int среди трех чисел.
    /// </summary>
    /// <param name="number1">Первое число.</param>
    /// <param name="number2">Второе число.</param>
    /// <param name="number3">Третее число.</param>
    /// <returns>Максимальное число.</returns>
    public static int MaxThreeNumbers(int number1, int number2, int number3)
    {
        int max = number1;
        if (max < number2) max = number2;
        if (max < number3) max = number3;
        return max;
    }
    /// <summary>
    /// Метод вычисления sin(x).
    /// </summary>
    /// <param name="value">Аргумент функции (угол в радианах).</param>
    /// <returns>Значение sin(x).</returns>
    public static double MathSin(double value)
    {
        return Math.Sin(value);
    }
    /// <summary>
    /// Метод проверки числа типа int на чётность.
    /// </summary>
    /// <param name="number">Число типа int.</param>
    public static void ParityCheck(int number)
    {
        if (number % 2 == 0)
            Console.WriteLine($"Число {number} является чётным.");
        else
            Console.WriteLine($"Число {number} является нечётным.");
    }
    /// <summary>
    /// Метод вывода последовательности чисел типа int от -N до N.
    /// </summary>
    /// <param name="number">Число N.</param>
    public static void OutputNumbers(int number)
    {
        string numbers = string.Empty;
        int count = -number;
        while (count <= number)
        {
            numbers += $"{count,-5}";
            count++;
        }
        Console.WriteLine($"Последовательность чисел от -N до N: {numbers}");
    }
}