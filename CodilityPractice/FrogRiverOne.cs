using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            // put all the unique indexes of the array in an hashset
            for (int i = 1; i <= X; i++)
            {
                set.Add(i);
            }


            for (int i = 0; i < A.Length; i++)
            {
                // when a number appears,
                // then, remove it from the set
                if (set.Contains(A[i]))
                { 
                    set.Remove(A[i]);             
                }
                if (set.Count == 0)
                {
                    // nothing in the set
                    // In second i, "1~X" have all appeared 
                    return i;                     
                }
            }

            // not all the elements "1~X" appeared
            return -1;
        }

    }
}
