using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int numberKeys = 0;
        foreach (KeyValuePair<string, string> ele in myDict)
        {
            numberKeys += 1;
        }
        return numberKeys;
    }
}

