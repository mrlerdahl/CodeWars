using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
     public class ArrayDiff
    {
        public static int[] ArraysDiff(int[] a, int[] b)
        {
            if (a.Length == 0)
                return a;
            if (b.Length == 0)
                return a;

           
            List<int> newAList = new List<int>();
            foreach (var item in a)
            {
                newAList.Add(item);
            }

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int k = 0; k < b.Length; k++)
            //    {
            //        if (a[i] == b[k])
            //            newAList.RemoveAt(i);
            //    }


            //}
            int count = 0;
            foreach (var aItem in a)
            {
                foreach (var bItem in b)
                {
                    if (aItem == bItem)
                        newAList.RemoveAt(count);
                }
                count++;
            }


            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == b[0])
            //        newAList.RemoveAt(i);

            //}

            count = 0;
            int[] newArray = new int[newAList.Count];
            foreach (var item in newAList)
            {
                newArray[count++] = item;
            }

            return newArray;

        }
    }
}
