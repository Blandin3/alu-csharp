using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        for (char c = 'a'; c <= 'z'; c++)
            if (c != 'q' && c != 'e')
                result += c;
        Console.Write(result);
    }
}

