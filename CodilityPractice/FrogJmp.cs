using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            var increment = X;
            var noOfJumps = 0;
            while(true)
            {
                if(increment >= Y)
                {
                    break;
                }
                else
                {
                    increment += D;
                    noOfJumps++;
                }
            }
            return noOfJumps;
        }
    }
}
