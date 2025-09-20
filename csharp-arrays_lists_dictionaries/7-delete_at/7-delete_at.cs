using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index out of range");
            return myList;
        }

        // Shift elements to the left manually (since .RemoveAt() is not allowed)
        for (int i = index; i < myList.Count - 1; i++)
        {
            myList[i] = myList[i + 1];
        }

        // Remove last element (duplicate after shifting)
        myList.RemoveAt(myList.Count - 1);

        return myList;
    }
}

