using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class DetectPangram
    {
        // Given a string, detect whether or not it is a pangram. Return True if it is, False if not. 
        //Ignore numbers and punctuation.
        public static bool IsPangram(string input)
        {
            input = input.ToLower();
            char findLetter = 'a';
            for (int i = 0; i < 26; i++)
            {
                if (!input.Contains(findLetter))
                    return false;
                findLetter++;
            }
            return true;

        }
    }
}
