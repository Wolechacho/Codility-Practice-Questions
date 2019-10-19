using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            //M queries
            //N integer in the array
            //
            var queries = new List<int>();
            S = S.ToUpper();
            var nucleotides = new Dictionary<char, int>()
            {
                ['A'] = 1,
                ['C'] = 2,
                ['G'] = 3,
                ['T'] = 4
            };
            for (int i = 0; i < P.Length; i++)
            {
                var min = -1;
                var end = Q[i] - P[i] + 1;
                var charArray = S.Substring(P[i], end).ToCharArray();
                foreach (var c in charArray)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (nucleotides.ContainsKey(charArray[j]))
                    {
                        var val = nucleotides[charArray[j]];
                        //for the first time
                        if (min == -1)
                        {
                            min = val;
                        }
                        else if (val < min)
                        {
                            min = val;
                        }
                    }
                }
                queries.Add(min);
            }
            return queries.ToArray();
        }
    }
}
