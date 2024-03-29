﻿
using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Stack<string> copyStack = new Stack<string>();
        int pop = 0;
        foreach (string item in aStack)
        {
            copyStack.Push(item);
        }
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        if (aStack.Contains(search) == true)
        {
            foreach (string item in copyStack)
            {
                aStack.Pop();
                if (pop == 1)
                {
                    break;
                }
                if (item == search)
                {
                    pop += 1;
                }
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
