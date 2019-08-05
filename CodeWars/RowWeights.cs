using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
   public class RowWeights
    {

    //Scenario
    //Several people are standing in a row divided into two teams.
    //The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

    //Task
    //Given an array of positive integers (the weights of the people), return a new array/tuple of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

    //Notes
    //Array size is at least 1.
    //All numbers will be positive.

        public static int[] RowWeight(int[] a)
        {
            int team1 = a[0];
            int team2 = 0;
            int[] b = new int[2];

            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 == 1)
                {
                    team2 += a[i];
                }
                else
                {
                    team1 += a[i];
                }
            }

            b[0] = team1;
            b[1] = team2;

            return b;

        }
    }
}
