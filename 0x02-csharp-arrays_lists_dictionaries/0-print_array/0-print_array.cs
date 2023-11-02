using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0) return null;
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                if (i < size - 1) Console.Write("{0} ", i);
                else Console.WriteLine(i);
            }
            return array;
        }
    }
}
