using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;

        // Print the percentage as a percentage with 2 decimal places
        Console.WriteLine("Percent: {0:P2}", percent);

        // Print the currency formatted as USD with 2 decimal places
        Console.WriteLine("Currency: {0:C2}", currency);
    }
}

