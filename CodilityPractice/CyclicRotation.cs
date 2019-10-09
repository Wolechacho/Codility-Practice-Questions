using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            //the trick is to shift the two rightmost element
            //set the previous to be the next
            for (int cycle = 0; cycle < K; cycle++)
            {
                var last = A[A.Length - 1];
                for (int i = A.Length - 2; i >= 0; i--)
                {
                    A[i + 1] = A[i];
                }
                A[0] = last;
            }
            return A;
        }
    }
}
