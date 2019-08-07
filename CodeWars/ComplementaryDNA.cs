using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class ComplementaryDNA
    {
        //In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
        //You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. 
        //DNA strand is never empty or there is no DNA at all (again, except for Haskell).
        public static string MakeComplement(string dna)
        {
            dna = dna.Replace('T', ' ');
            dna = dna.Replace('A', 'T');
            dna = dna.Replace(' ', 'A');
            dna = dna.Replace('C', ' ');
            dna = dna.Replace('G', 'C');
            dna = dna.Replace(' ', 'G');

            return dna;
        }
    }
}
