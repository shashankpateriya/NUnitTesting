using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class SwapNibble
    {
        public static void ReadInput()
        {
            int number;
            Console.WriteLine("Enter the value of Decimal number");
            number = Convert.ToInt32(Console.ReadLine());

            ToBinary(number);
        }
        private static void ToBinary(int number)
        {
            Console.WriteLine("Decimal number before swapped = {number}");
            int binaryNumber = ((number & 0x0F) << 4 | (number & 0xF0) >> 4);

            Console.WriteLine($"Decimal number after swapped = {binaryNumber}");

            // check whether it is power of two
            bool value = checkPower(binaryNumber);

            Console.WriteLine(value ? $"{binaryNumber} is power of two" : $"{ binaryNumber} is not power of two");
        }
        private static bool checkPower(int binaryNumber)
        {
            while (binaryNumber != 1)
            {
                if (binaryNumber % 2 != 0)
                    return false;

                binaryNumber /= 2;
            }
            return true;
        }
    }
}