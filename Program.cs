using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NUnit programs");
            Console.WriteLine("Press 1. for Vending Machine.");
            Console.WriteLine("Press 2. for Day of Week.");
            Console.WriteLine("Press 3. for Temperature Conversion.");
            Console.WriteLine("Press 4. for Monthly Payment.");
            Console.WriteLine("Press 5. for NewtonsMethod.");
            Console.WriteLine("Press 6. for Decimal to Binary.");
            Console.WriteLine("Press 7. for Swap nibble.");
            Console.WriteLine("Enter a choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    VendingMachine.PrintingNotes();
                    break;

                case 2:
                    DayOfWeek.ReadInput();
                    break;

                case 3:
                    TemperatureConversion.Conversion();
                    break;

                case 4:
                    MonthlyPayment.ReadInput();
                    break;

                case 5:
                    Sqrt.ReadInput();
                    break;

                case 6:
                    DecimalToBinary.ReadInput();
                    break;

                case 7:
                    SwapNibble.ReadInput();
                    break;
            }
        }
    }
}