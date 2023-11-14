using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        foreach (int el in list1)
        {
            if (!(list1.Contains(el) && list2.Contains(el)))
            {
                newList.Add(el);
            }
        }
        foreach (int el in list2)
        {
            if (!(list2.Contains(el) && list1.Contains(el)))
            {
                newList.Add(el);
            }
        }
        newList.Sort();
        return newList;
    }
}

