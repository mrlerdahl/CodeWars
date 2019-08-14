using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    // Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
    // You don't need to validate the form of the Roman numeral.
    public class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            int romanToNumeric = 0;
            int[] romanValues = new int[roman.Length];

            for (int i = 0; i < roman.Length; i++)
            {
                switch (char.ToUpper(roman[i]))
                {
                    case 'I':
                        romanValues[i] = 1;
                        break;
                    case 'V':
                        romanValues[i] = 5;
                        break;
                    case 'X':
                        romanValues[i] = 10;
                        break;
                    case 'L':
                        romanValues[i] = 50;
                        break;
                    case 'C':
                        romanValues[i] = 100;
                        break;
                    case 'D':
                        romanValues[i] = 500;
                        break;
                    case 'M':
                        romanValues[i] = 1000;
                        break;
                    default:
                        break;

                }
            }
            for (int i = 1; i < romanValues.Length; i++)
            {
                if (romanValues[i - 1] < romanValues[i])
                    romanToNumeric -= romanValues[i - 1];
                else
                    romanToNumeric += romanValues[i - 1];
            }
            romanToNumeric += romanValues[romanValues.Length - 1];

            return romanToNumeric;
        }
    }
}
