using System;
using System.Collections.Generic;


class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int node = 0;
        int count = 0;
        foreach (int num in myLList)
        {
            if (count == index)
            {
                node = num;
                break;
            }
            count += 1;

        }
        myLList.Remove(node);
    }
}

