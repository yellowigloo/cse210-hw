using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction set0 = new Fraction(1, 1);
        set0.SetTop(5);
        set0.SetBottom(2);
        Console.WriteLine(set0.GetTop());
        Console.WriteLine(set0.GetBottom());
        
        Fraction set5 = new Fraction();
        Console.WriteLine(set5.GetFractionString());
        Console.WriteLine(set5.GetDecimalValue());

        Fraction set1 = new Fraction(1);
        Console.WriteLine(set1.GetFractionString());
        Console.WriteLine(set1.GetDecimalValue());

        Fraction set2 = new Fraction(5);
        Console.WriteLine(set2.GetFractionString());
        Console.WriteLine(set2.GetDecimalValue());

        Fraction set3 = new Fraction(3, 4);
        Console.WriteLine(set3.GetFractionString());
        Console.WriteLine(set3.GetDecimalValue());

        Fraction set4 = new Fraction(1, 3);
        Console.WriteLine(set4.GetFractionString());
        Console.WriteLine(set4.GetDecimalValue());
    }
}