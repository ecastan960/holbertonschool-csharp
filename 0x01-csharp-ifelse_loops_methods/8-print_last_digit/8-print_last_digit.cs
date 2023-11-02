using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int lastNumber = number % 10;
            if (lastNumber < 0) lastNumber = lastNumber * -1;
            Console.Write(lastNumber);
            return lastNumber;
        }
    }
}
