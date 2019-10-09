using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class OddOccurencesInArray
    {
        
        public static int Solution(int[] A)
        {
            //unmatched List
            var unmatchedList = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!unmatchedList.Contains(A[i]))
                {
                    unmatchedList.Add(A[i]);
                }
                else
                {
                    unmatchedList.Remove(A[i]);
                }
            }
            return unmatchedList.FirstOrDefault();
        }
    }
}
