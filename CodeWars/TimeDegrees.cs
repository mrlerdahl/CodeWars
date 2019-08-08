using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class TimeDegrees
    {
        public static string ClockDegree(string s)
        {
            string[] timeSplit = s.Split(':');
            if (int.Parse(timeSplit[0]) >= 24 || int.Parse(timeSplit[0]) < 0)
                return "Check your time !";
            if (int.Parse(timeSplit[1]) >= 60 || int.Parse(timeSplit[1]) < 0)
                return "Check your time !";

            if (int.Parse(timeSplit[0]) > 12)
                timeSplit[0] = (int.Parse(timeSplit[0]) - 12).ToString();

            int degreeOne = int.Parse(timeSplit[0]) * 30;
            int degreeTwo = int.Parse(timeSplit[1]) * 6;


            if (degreeOne == 0)
                degreeOne = 360;
            if (degreeTwo == 0)
                degreeTwo = 360;

            return $"{degreeOne}:{degreeTwo}";
        }
    }
}
