using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-10, 11); // generates number between -10 and 10 inclusive

        if (number > 0)
            Console.WriteLine($"{number} is positive");
        else if (number == 0)
            Console.WriteLine($"{number} is zero");
        else
            Console.WriteLine($"{number} is negative");
    }
}

