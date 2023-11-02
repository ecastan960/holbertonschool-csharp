using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                Console.Write("{0}, ", String.Format("{0:00}", i));
            }
            Console.Write("99\n");
        }
    }
}
