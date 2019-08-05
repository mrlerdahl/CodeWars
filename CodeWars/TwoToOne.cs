using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class TwoToOne
    {
        //Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,
        // each taken only once - coming from s1 or s2.
        public static string Longest(string s1, string s2)
        {
            string strMerge = s1 + s2;

            string result = "";

            foreach (char value in strMerge)
            {

                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }

            char[] c1 = result.ToCharArray();
            Array.Sort(c1);

            return new string(c1);

        }
    }
}
