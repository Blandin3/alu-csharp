using System;

class Program
{
    static void Main()
    {
        string word = "Holberton";

        // Get the first 3 letters of the word
        string word_first_3 = word.Substring(0, 3);

        // Get the last 2 letters of the word
        string word_last_2 = word.Substring(word.Length - 2);

        // Get the middle part of the word (without the first and last letters)
        string middle_word = word.Substring(1, word.Length - 2);

        // Print the results
        Console.WriteLine("First 3 letters: " + word_first_3);
        Console.WriteLine("Last 2 letters: " + word_last_2);
        Console.WriteLine("Middle word: " + middle_word);
    }
}

