using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
   public class VowelCount
    {

    // Return the number(count) of vowels in the given string.
    // We will consider a, e, i, o, and u as vowels for this Kata.
    // The input string will only consist of lower case letters and/or spaces.
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] c1 = str.ToCharArray();

            for (int i = 0; i < c1.Length; i++)
            {
                if (c1[i] == 'a' || c1[i] == 'e' || c1[i] == 'i' || c1[i] == 'o' || c1[i] == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
