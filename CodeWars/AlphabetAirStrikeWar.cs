using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class AlphabetAirStrikeWar
    {
        // Write a function that accepts fight string consists of only small letters and * which means a bomb drop place. 
        //Return who wins the fight after bombs are exploded. When the left side wins return Left side wins!, 
        //when the right side wins return Right side wins!, in other case return Let's fight again!.


        
        public static string AlphabetWar(string str)
        {

            string newStr = "";
            if (str.StartsWith('*'))
            {
                str = str.Remove(0, 2);
            }
            if (str.EndsWith('*'))
            {
                str = str.Remove(str.Length - 2, 2);
            }

            string[] strings = str.Split('*');
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 1)
                {
                    strings[i] += "";
                    continue;
                }
                strings[i] = strings[i].Substring(0, strings[i].Length);
            }
            foreach (var s in strings)
            {
                newStr += s;
            }

            int leftSideScore = 0;
            int rightSideScore = 0;

            foreach (var letter in newStr)
            {
                switch (letter)
                {
                    case 'w':
                        leftSideScore += 4;
                        break;
                    case 'p':
                        leftSideScore += 3;
                        break;
                    case 'b':
                        leftSideScore += 2;
                        break;
                    case 's':
                        leftSideScore += 1;
                        break;
                    case 'm':
                        rightSideScore += 4;
                        break;
                    case 'q':
                        rightSideScore += 3;
                        break;
                    case 'd':
                        rightSideScore += 2;
                        break;
                    case 'z':
                        rightSideScore += 1;
                        break;
                }
            }

            if (leftSideScore == rightSideScore)
                return "Let's fight again!";

            return (leftSideScore > rightSideScore) ? "Left side wins!" : "Right side wins!";

        }
    }
}
