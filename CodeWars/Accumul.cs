using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    //This time no story, no theory.The examples below show you how to write function accum:

    //Examples:
    //accum("abcd") -> "A-Bb-Ccc-Dddd"
    //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    //accum("cwAt") -> "C-Ww-Aaa-Tttt"

    //The parameter of accum is a string which includes only letters from a..z and A..Z.

    public class Accumul
    {
        public static String Accum(string s)
        {

            string newStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        newStr += char.ToUpper(s[i]);
                    }
                    else
                    {
                        newStr += char.ToLower(s[i]);
                    }

                }

                newStr += "-";
            }

            newStr = newStr.Substring(0, newStr.Length - 1);
            return newStr;
        }

    }
}
