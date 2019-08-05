using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{

    // Remove all exclamation marks from sentence except at the end.
    public class RemoveExclamation
    {
        public static string Remove(string s)
        {
            string newStr = "";
            string addEx = "";

            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] == '!')
                {
                    addEx += s[i];
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '!')
                {
                    continue;
                }
                newStr += s[i];
            }


            return newStr + addEx;
        }
    }
}
