using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class Sqrt
    {
        public static void ReadInput()
        {
            //Get the input from user
            Console.WriteLine("Enter the number : ");
            double c = Convert.ToDouble(Console.ReadLine());
            NewtonSquareRoot(c);
        }
        public static void NewtonSquareRoot(double c)
        {
            double t = c;
            double root = 0;
            int i = 0;
            while (true)
            {
                root = 0.5 * (t + (c / t));
                double epsilon = 1e-15;
                if (Math.Abs(t - c / t) < epsilon * t)
                {
                    break;
                }
                t = root;
                i++;
            }
            Console.WriteLine(root);
        }

    }
}