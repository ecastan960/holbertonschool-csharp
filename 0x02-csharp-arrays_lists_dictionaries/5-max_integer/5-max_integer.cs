﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = 0;
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] > max) max = myList[i];
        }
        return max;
    }
}

