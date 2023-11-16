﻿using System;
using System.Collections.Generic;



class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> my_list = new LinkedList<int>();
        if (size < 0) return my_list;
        for (int i = 0; i < size; i++)
        {
            my_list.AddLast(i);
        }
        foreach (int j in my_list)
        {
            Console.WriteLine(j);
        }
        return my_list;
    }
}


