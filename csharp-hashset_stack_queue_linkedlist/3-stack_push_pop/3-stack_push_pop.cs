using System;
using System.Collections.Generic;

class MyStack
{
    // Method that processes a stack as per requirements
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Case: Stack is empty
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            // Print number of items
            Console.WriteLine("Number of items: " + aStack.Count);

            // Print top item without removing
            Console.WriteLine("Top item: " + aStack.Peek());
        }

        // Print whether stack contains search
        bool contains = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {contains}");

        // If contains, remove all items up to and including search
        if (contains)
        {
            Stack<string> tempStack = new Stack<string>();

            // Move items until we reach the search item
            while (aStack.Count > 0)
            {
                string item = aStack.Pop(); // <-- only Pop() used here
                if (item == search)
                {
                    break;
                }
                tempStack.Push(item);
            }

            // Push remaining tempStack items back (to restore order below search)
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add new item
        aStack.Push(newItem);

        return aStack;
    }
}

