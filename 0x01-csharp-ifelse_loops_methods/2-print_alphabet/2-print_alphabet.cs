using System;

namespace _2_print_alphabet
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
                alphabet = alphabet + text;
            }
            Console.Write("{0}", alphabet);
        }
    }
}
