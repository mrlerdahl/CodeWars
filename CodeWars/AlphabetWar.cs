using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class AlphabetWar
    {
        // Task
        // Write a function that accepts fight string consists of only small letters and return who wins the fight.
        // When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.
        // The left side letters and their power:
        public static string War(string fight)
        {
            int leftSideScore = 0;
            int rightSideScore = 0;

            foreach (var letter in fight)
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

            if (leftSideScore > rightSideScore)
                return "Left side wins!";
            if (leftSideScore == rightSideScore)
                return "Let's fight again!";

            

            return "Right side wins!";
        }
    }
}
