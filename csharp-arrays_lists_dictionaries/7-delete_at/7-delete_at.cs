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

        // Create a new list to avoid using .RemoveAt()
        List<int> newList = new List<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index) // skip the element at 'index'
                newList.Add(myList[i]);
        }

        return newList;
    }
}



