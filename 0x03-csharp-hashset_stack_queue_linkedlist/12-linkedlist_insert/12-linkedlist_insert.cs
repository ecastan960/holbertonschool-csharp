using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int nextNodeValue = 0;
        foreach (int number in myLList)
        {
            if (number > n)
            {
                nextNodeValue = number;
                break;
            }
        }
        LinkedListNode<int> temp = myLList.Find(nextNodeValue);
        myLList.AddBefore(temp, n);
        return myLList.Find(n);
    }
}

