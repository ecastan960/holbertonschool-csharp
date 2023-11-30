using System;
using System.Collections.Generic;

namespace run
{
    class Program
    {
        static void Main(string[] args)
        {
		List<int> list = new List<int>();
            	list.Add(1);
            	list.Add(2);
            	list.Add(3);
            	list.Add(4);
		Console.WriteLine(MyMath.Operations.Max(list));
        }
    }
}
