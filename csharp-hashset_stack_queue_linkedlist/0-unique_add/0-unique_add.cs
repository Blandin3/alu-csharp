using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    // Method that returns the sum of unique integers in a list
    public static int Sum(List<int> myList)
    {
        // Use HashSet to keep only unique integers
        HashSet<int> uniqueNumbers = new HashSet<int>(myList);

        // Sum all unique numbers
        int sum = 0;
        foreach (int num in uniqueNumbers)
        {
            sum += num;
        }

        return sum;
    }
}

