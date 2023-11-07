using System;

public class Calculator<T>
{
    public Func<T, T, T> Додавання { get; set; }
    public Func<T, T, T> Віднімання { get; set; }
    public Func<T, T, T> Множення { get; set; }
    public Func<T, T, T> Ділення { get; set; }

    public Calculator(Func<T, T, T> додавання, Func<T, T, T> віднімання, Func<T, T, T> множення, Func<T, T, T> ділення)
    {
        Додавання = додавання;
        Віднімання = віднімання;
        Множення = множення;
        Ділення = ділення;
    }

    public T ВиконатиДодавання(T a, T b)
    {
        return Додавання(a, b);
    }

    public T ВиконатиВіднімання(T a, T b)
    {
        return Віднімання(a, b);
    }

    public T ВиконатиМноження(T a, T b)
    {
        return Множення(a, b);
    }

    public T ВиконатиДілення(T a, T b)
    {
        return Ділення(a, b);
    }
}

class Program
{
    static void Main()
    {
        // Створення дженеричного калькулятора для цілих чисел (int)
        Calculator<int> intCalculator = new Calculator<int>(
            (a, b) => a + b,
            (a, b) => a - b,
            (a, b) => a * b,
            (a, b) => a / b
        );

        int додаванняРезультат = intCalculator.ВиконатиДодавання(5, 3);
        int відніманняРезультат = intCalculator.ВиконатиВіднімання(8, 4);
        int множенняРезультат = intCalculator.ВиконатиМноження(6, 2);
        int діленняРезультат = intCalculator.ВиконатиДілення(10, 2);

        Console.WriteLine($"Додавання: {додаванняРезультат}");
        Console.WriteLine($"Віднімання: {відніманняРезультат}");
        Console.WriteLine($"Множення: {множенняРезультат}");
        Console.WriteLine($"Ділення: {діленняРезультат}");

        // Створення дженеричного калькулятора для дійсних чисел (double)
        Calculator<double> doubleCalculator = new Calculator<double>(
            (a, b) => a + b,
            (a, b) => a - b,
            (a, b) => a * b,
            (a, b) => a / b
        );

        double додаванняРезультатDouble = doubleCalculator.ВиконатиДодавання(5.5, 3.2);
        double відніманняРезультатDouble = doubleCalculator.ВиконатиВіднімання(8.7, 4.1);
        double множенняРезультатDouble = doubleCalculator.ВиконатиМноження(6.2, 2.5);
        double діленняРезультатDouble = doubleCalculator.ВиконатиДілення(10.0, 2.0);

        Console.WriteLine($"Додавання (double): {додаванняРезультатDouble}");
        Console.WriteLine($"Віднімання (double): {відніманняРезультатDouble}");
        Console.WriteLine($"Множення (double): {множенняРезультатDouble}");
        Console.WriteLine($"Ділення (double): {діленняРезультатDouble}");
    }
}
