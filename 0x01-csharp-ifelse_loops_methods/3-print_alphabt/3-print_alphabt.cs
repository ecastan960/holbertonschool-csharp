using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "";
            for (int i = 97; i < 123; i++)
            {
                char character = (char)i;
                string text = character.ToString();
                if (text == "q" || text == "e")
                {
                    continue;
                }
                alphabet = alphabet + text;
            }
            Console.Write("{0}", alphabet);
        }
    }
}
