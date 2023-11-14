using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0) return "None";
        var sortedDict = myList.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        var last = sortedDict.Last();
        return last.Key;
    }
}

