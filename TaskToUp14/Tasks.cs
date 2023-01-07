class Tasks
{
    /// <summary>
    /// Задача 0. Вывести квадрат числа.
    /// </summary>
    public static void Task0()
    {
        Console.WriteLine("Введите число, которое необходимо возвести в квадрат:");
        int number = MyMethods.InputNumberInt();
        Console.WriteLine($"Квадрат числа {number} равен: {MyMethods.SquareNumber(number)}.");
    }
}