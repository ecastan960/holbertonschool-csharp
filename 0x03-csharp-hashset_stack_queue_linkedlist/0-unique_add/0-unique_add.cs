using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> myHash = new HashSet<int>();
        int sum = 0;
        foreach (int n in myList)
        {
            myHash.Add(n);
        }
        foreach (int s in myHash)
        {
            sum = sum + s;
        }
        return sum;
    }
}

