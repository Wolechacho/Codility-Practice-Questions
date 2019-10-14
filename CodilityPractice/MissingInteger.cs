using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);
            var counter = 0;
            var ans = 0;
            while(true)
            {
                if(A.Length - 1 == counter)
                {
                    if(A[A.Length - 1] > 0)
                    {
                        return A[A.Length - 1] + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    var prev = A[counter];
                    var next = A[counter + 1];
                    var diff = next - prev;
                    if (diff > 1)
                    {
                        ans = A[counter] + 1;
                        if (ans > 0)
                        {
                            return ans;
                        }
                    }
                }
                counter++;
            }
        }
    }
}
