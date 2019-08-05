using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class GrowthOfPopulation
    {

        // In a small town the population is p0 = 1000 at the beginning of a year. 
        // The population regularly increases by 2 percent per year and moreover 50 new inhabitants per year come to live in the town. 
        // How many years does the town need to see its population greater or equal to p = 1200 inhabitants?
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int i = 0;

            for (i = 0; p0 < p; i++)
            {
                p0 += (int)(p0 * percent / 100) + aug;

            }

            return i;

        }
    }
}
