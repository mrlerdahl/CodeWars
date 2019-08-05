using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class SquareEveryDigit
    {
        // Welcome. In this kata, you are asked to square every digit of a number.
        // For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
        // Note: The function accepts an integer and returns an integer

        public static int SquareDigits(int n)
        {

            double p;
            string y = n.ToString();
            string addP = "";

            for (int i = 0; i < y.Length; i++)
            {
                p = y[i] - '0';

                p = Math.Pow(p, 2);
                addP += p.ToString();
            }

            return int.Parse(addP);
        }
    }
}
