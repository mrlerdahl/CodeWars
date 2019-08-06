using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class GetMiddleCharacter
    {

        //You are going to be given a word. Your job is to return the middle character of the word. 
        //If the word's length is odd, return the middle character. 
        //If the word's length is even, return the middle 2 characters.


        // This method first determins if the string has an even number of elements or an odd number
        // Dividing the length of the string by two gives the middle
        // Since indexing starts at 0 I have to subtract to get the first middle letter of an even element string
        // findMiddle when divided for odd elements in a string returns a decimil which will be trunkcated, meaning we don't need to subtract one for the proper index
        public static string GetMiddle(string s)
        {
            int findMiddle;
            string newStr = "";

            if (s.Length % 2 == 0)
            {
                findMiddle = s.Length / 2;
                newStr += s[findMiddle - 1];
                newStr += s[findMiddle];
            }
            if (s.Length % 2 == 1)
            {
                findMiddle = s.Length / 2;
                newStr += s[findMiddle];
            }

            return newStr;
        }
    }
}
