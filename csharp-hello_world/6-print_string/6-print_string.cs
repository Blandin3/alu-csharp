using System;

class Program
{
    static void Main()
    {
        string str = "Holberton School";  // Declare and initialize the string variable

        // Print the string 3 times
        Console.WriteLine(str + str + str);

        // Print the first 9 characters of the string
        Console.WriteLine(str.Substring(0, 9));
    }
}

