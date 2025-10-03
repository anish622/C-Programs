using System;

class CurrencyConverter
{
    static void Main()
    {
        // Current exchange rates (as of October 2025)
        const double INR_TO_USD = 0.01127;
        const double INR_TO_EUR = 0.0106;
        const double INR_TO_GBP = 0.0091;

        Console.WriteLine("INR Currency Converter");
        Console.Write("Enter amount in INR: ");
        double inrAmount = Convert.ToDouble(Console.ReadLine());

        double usd = inrAmount * INR_TO_USD;
        double eur = inrAmount * INR_TO_EUR;
        double gbp = inrAmount * INR_TO_GBP;

        Console.WriteLine($"\nConverted Amounts:");
        Console.WriteLine($"USD: ${usd:F2}");
        Console.WriteLine($"EUR: €{eur:F2}");
        Console.WriteLine($"GBP: £{gbp:F2}");
    }
}
