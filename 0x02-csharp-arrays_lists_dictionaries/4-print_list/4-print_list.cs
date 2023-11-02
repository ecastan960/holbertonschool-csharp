using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> iList = new List<int>();
        if (size == 0)
        {
            Console.WriteLine();
            return iList;
        }
        for (int i = 0; i < size; i++)
        {
            if (i < size - 1) Console.Write("{0} ", i);
            else Console.WriteLine(i);
            iList.Add(i);
        }
        return iList;
    }
}
