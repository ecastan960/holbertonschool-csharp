using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int nextNodeValue = 0;
        bool firstNode = true;
        foreach (int number in myLList)
        {
            if (n < number && firstNode == true)
            {
                nextNodeValue = -1;
                break;
            }
            if (number >= n)
            {
                nextNodeValue = number;
                break;
            }
            firstNode = false;
        }
        if (nextNodeValue == -1)
        {
            myLList.AddFirst(n);
        }
        else if (nextNodeValue == 0)
        {
            myLList.AddLast(n);
        }
        else
        {
            LinkedListNode<int> temp = myLList.Find(nextNodeValue);
            myLList.AddBefore(temp, n);
        }
        return myLList.Find(n);
    }
}

