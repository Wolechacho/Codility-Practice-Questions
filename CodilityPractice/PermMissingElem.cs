using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            Array.Sort<int>(A);
            var missingElem = 0;
            for (int i = 0; i < A.Length -1 ; i++)
            {
                var diff = A[i + 1] - A[i];
                if(diff != 1)
                {
                    missingElem = A[i] + 1;
                    break;
                }
            }
            return missingElem;
        }
    }
}
