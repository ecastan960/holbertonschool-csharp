using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = myDict.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        foreach (KeyValuePair<string, string> pair in sortedDict)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
