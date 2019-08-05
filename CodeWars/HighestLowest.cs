using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class HighestLowest
    {

    // In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

    //Example:
    //Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
    //Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
    //Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

    //Notes:
    //All numbers are valid Int32, no need to validate them.
    //There will always be at least one number in the input string.
    //Output string must be two numbers separated by a single space, and highest number is first.
        public static string HighAndLow(string numbers)
        {

            string[] values = numbers.Split(' ');
            int[] toNum = Array.ConvertAll<string, int>(values, int.Parse);
            int val = toNum[0];
            int val2 = toNum[0];

            for (int i = 0; i < toNum.Length; i++)
            {
                if (toNum[i] > val)
                {
                    val = toNum[i];
                }
                if (toNum[i] < val2)
                {
                    val2 = toNum[i];
                }
            }

            return $"{val} {val2}";
        }
    }
}
