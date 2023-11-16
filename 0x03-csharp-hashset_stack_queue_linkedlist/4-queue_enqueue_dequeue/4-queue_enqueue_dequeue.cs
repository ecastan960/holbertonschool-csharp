using System;
using System.Collections.Generic;
using System.Collections;


class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Queue<string> copyQueue = new Queue<string>();
        foreach (string item in aQueue)
        {
            copyQueue.Enqueue(item);
        }

        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        aQueue.Enqueue(newItem);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        if (aQueue.Contains(search) == true)
        {
            foreach (string item in copyQueue)
            {
                aQueue.Dequeue();
                if (item == search)
                {
                    break;
                }
            }
        }
        return aQueue;
    }
}

