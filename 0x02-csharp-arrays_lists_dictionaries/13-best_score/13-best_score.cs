using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0) return "None";
        string key = "";
        int score = 0;
        foreach (KeyValuePair<string, int> ele in myList)
        {
            if (ele.Value > score)
            {
                key = ele.Key;
                score = ele.Value;
            }
        }
        return key;
    }
}

