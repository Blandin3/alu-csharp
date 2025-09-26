using System;
using System.Collections.Generic;

class MyQueue
{
    // Method that processes a queue as per requirements
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Case: Queue is empty
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            // Print number of items
            Console.WriteLine("Number of items: " + aQueue.Count);

            // Print first item without removing
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        // Add new item at the end
        aQueue.Enqueue(newItem);

        // Print whether queue contains search
        bool contains = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {contains}");

        // If contains, remove items up to and including search
        if (contains)
        {
            Queue<string> tempQueue = new Queue<string>();

            // Move items until we reach the search item
            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue(); // <-- only Dequeue() used here
                if (item == search)
                {
                    break;
                }
                tempQueue.Enqueue(item);
            }

            // Add back the remaining items after search
            while (aQueue.Count > 0)
            {
                tempQueue.Enqueue(aQueue.Dequeue());
            }

            // Replace aQueue with the filtered queue
            aQueue = tempQueue;
        }

        return aQueue;
    }
}

