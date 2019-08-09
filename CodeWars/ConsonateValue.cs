using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class ConsonateValue
    {
        public static int Solve(string s)
        {
            //Given a lowercase string that has alphabetic characters only and no spaces, return the highest value of consonant substrings. 
            //Consonants are any letters of the alpahabet except "aeiou".
           // We shall assign the following values: a = 1, b = 2, c = 3, ....z = 26.

            s = s.ToLower();
            int largestScore = 0;
            int countScore = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].Equals('a') || s[i].Equals('e') || s[i].Equals('i') || s[i].Equals('o') || s[i].Equals('u'))
                {
                    if(countScore > largestScore)
                    {
                        largestScore = countScore;
                    }
                    countScore = 0;
                    continue;
                }
                
                switch (s[i])
                {
                    case 'b':
                        countScore += 2;
                        break;
                    case 'c':
                        countScore += 3;
                        break;
                    case 'd':
                        countScore += 4;
                        break;
                    case 'f':
                        countScore += 6;
                        break;
                    case 'g':
                        countScore += 7;
                        break;
                    case 'h':
                        countScore += 8;
                        break;
                    case 'j':
                        countScore += 10;
                        break;
                    case 'k':
                        countScore += 11;
                        break;
                    case 'l':
                        countScore += 12;
                        break;
                    case 'm':
                        countScore += 13;
                        break;
                    case 'n':
                        countScore += 14;
                        break;
                    case 'p':
                        countScore += 16;
                        break;
                    case 'q':
                        countScore += 17;
                        break;
                    case 'r':
                        countScore += 18;
                        break;
                    case 's':
                        countScore += 19;
                        break;
                    case 't':
                        countScore += 20;
                        break;
                    case 'v':
                        countScore += 22;
                        break;
                    case 'w':
                        countScore += 23;
                        break;
                    case 'x':
                        countScore += 24;
                        break;
                    case 'y':
                        countScore += 25;
                        break;
                    case 'z':
                        countScore += 26;
                        break;
                }
            }

            if (countScore > largestScore)
                largestScore = countScore;


            return largestScore;
        }
    }
}
