
using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intarray = new int[5, 5];
            intarray[2, 2] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4)
                    {
                        Console.Write("{0} ", intarray[i, j]);
                    }
                    else
                    {
                        Console.WriteLine(intarray[i, j]);
                    }
                }
            }
        }
    }
}
