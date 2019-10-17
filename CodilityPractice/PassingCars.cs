using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class PassingCars
    {
        public static int Solution(int[] A)
        {
            var numofOnes = A.Where(num => num == 1).Count();
            var oneCounter = 0;
            var sum = 0;
            var passingCarThreshold = 1000000000;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] == 1)
                {
                    oneCounter++;
                }
                else
                {
                    sum += numofOnes - oneCounter;
                }
            }
            return sum > passingCarThreshold ? -1 : sum;

        }
    }
}
