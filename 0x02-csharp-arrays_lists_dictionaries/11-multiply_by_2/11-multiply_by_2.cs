using System.Collections.Generic;
using System;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> el in myDict)
        {
            newDict[el.Key] = el.Value * 2;
        }
        return newDict;
    }
}

