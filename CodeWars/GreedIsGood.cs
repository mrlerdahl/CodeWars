using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class GreedIsGood
    {
        public static int Score(int[] dice)
        {
            int score = 0;
            int[] counter = new int[] { 0, 0, 0, 0, 0, 0 };

            foreach (var item in dice)
            {
                switch (item)
                {
                    case 1:
                        counter[0]++;
                        break;
                    case 2:
                        counter[1]++;
                        break;
                    case 3:
                        counter[2]++;
                        break;
                    case 4:
                        counter[3]++;
                        break;
                    case 5:
                        counter[4]++;
                        break;
                    case 6:
                        counter[5]++;
                        break;
                    default:
                        break;
                }

            }

            if (counter[0] >= 3)
                score += 1000;
            if (counter[0] == 4)
                score += 100;
            else if (counter[0] == 5)
                score += 200;
            if (counter[0] == 2)
                score += 200;
            else if (counter[0] == 1)
                score += 100;

            if (counter[1] >= 3)
                score += 200;

            if (counter[2] >= 3)
                score += 300;

            if (counter[3] >= 3)
                score += 400;

            if (counter[4] == 2)
                score += 100;
            else if (counter[4] == 1)
                score += 50;
            if (counter[4] >= 3)
                score += 500;
            if (counter[4] == 4)
                score += 50;
            else if (counter[4] == 5)
                score += 100;


            if (++counter[5] >= 3)
                score += 600;

            return score;
        }
    }
}
