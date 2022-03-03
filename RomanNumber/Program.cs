class Program
{
    static void Main()
    {
        RomanNumber a = new RomanNumber(1234);
        RomanNumber b = new RomanNumber(3999);
        RomanNumber c = new RomanNumber(4);
        RomanNumber d = new RomanNumber(100);

        Console.WriteLine("Конвертер");
        Console.WriteLine("A = 1234 = MCCXXXIV: " + a.ToString());
        Console.WriteLine("B = 3999 = MMMCMXCIX: " + b.ToString());
        Console.WriteLine("C = 4 = IV: " + c.ToString());
        Console.WriteLine("D = 100 = C : " + d.ToString());
        Console.WriteLine("");

        Console.WriteLine("Арифметические операции");
        Console.WriteLine("A + C = 1238 = MCCXXXVIII: " + (a+c).ToString());
        Console.WriteLine("A - C = 2995 = MCCXXX: " + (a-c).ToString());
        Console.WriteLine("C * D = 400 = CD: " + (c*d).ToString());
        Console.WriteLine("D / C = 25 = XXV: " + (d/c).ToString());
        Console.WriteLine("");

        Console.WriteLine("Сортировка");
        RomanNumber[] numbers = { a, b, c, d };
        Array.Sort(numbers);
        foreach (RomanNumber number in numbers)
        {
            Console.WriteLine(number.ToString());
        }
        Console.WriteLine("");

        Console.WriteLine("Копирование");
        var copied = (RomanNumber)d.Clone();
        Console.WriteLine(copied.ToString());
    }
}
