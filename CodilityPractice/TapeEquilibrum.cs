using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class TapeEquilibrum
    {
        public  static long Solution(int[] A)
        {
            List<long> diffs = new List<long>();
            long left = 0;
            long sum = A.Sum();
            foreach (int item in A)
            {
                left += item;
                var diff = ((sum - left) - left);
                diffs.Add(Math.Abs(diff));
            }
            return diffs.Min();
        }
    }
}
