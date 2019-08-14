using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class FishInThePond
    {
        public static int fish(string shoal)
        {
            int fishLevel = 1;
            double pointCounter = 0;
            double[] fishArray = new double[shoal.Length];
            for (int i = 0; i < shoal.Length; i++)
            {
                fishArray[i] = char.GetNumericValue(shoal[i]);
                
            }

            Array.Sort(fishArray);
            foreach (var item in fishArray)
            {
                Console.Write(item + ", ");
            }

            foreach (var item in fishArray)
            {
                if (fishLevel >= item)
                {
                    pointCounter += item;
                }
                else
                {
                    return (int)item;
                }
                Console.WriteLine(pointCounter);
                switch (pointCounter)
                {
                    case 4:
                        fishLevel += 1;
                        break;
                    case 12:
                        fishLevel += 1;
                        break;
                    case 24:
                        fishLevel += 1;
                        break;
                    case 40:
                        fishLevel += 1;
                        break;
                    case 60:
                        fishLevel += 1;
                        break;
                    case 84:
                        fishLevel += 1;
                        break;
                    case 112:
                        fishLevel += 1;
                        break;
                    case 144:
                        fishLevel += 1;
                        break;
                    case 180:
                        fishLevel += 1;
                        break;
                }
            }

            return fishLevel;
        }
    }
}
