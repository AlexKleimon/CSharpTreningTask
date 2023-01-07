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
}