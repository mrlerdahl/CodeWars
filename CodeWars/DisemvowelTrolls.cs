using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class DisemvowelTrolls
    {
        public static string Disemvowel(string str)
        {
            string newStr = "";
            foreach (var letter in str)
            {
                if (letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') || letter.Equals('u'))
                    continue;
                if (letter.Equals('A') || letter.Equals('E') || letter.Equals('I') || letter.Equals('O') || letter.Equals('U'))
                    continue;
                newStr += letter;
            }

            return newStr;
        }
    }
}
