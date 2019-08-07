using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class SquareOfSquares
    {
        //Given an integral number, determine if it's a square number:
        public static bool IsSquare(int n)
        {
            if (Math.Sqrt(n) % 1 == 0)
                return true;

            return false;
        }
    }
}
