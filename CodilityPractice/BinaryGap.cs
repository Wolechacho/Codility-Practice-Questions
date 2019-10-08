using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    public class BinaryGap
    {
        public static int Solution(long number)
        {
            //N = the number to convert to binary
            //binary = the binary representation of the number
            //binaryMaxLength = the maximum length of binary

            //split the number to char array of number
            
            var strb = new StringBuilder();
            var maxlength = 0;
            var binary = Convert.ToString(number, 2).ToString();
            Console.WriteLine($"Binary output {binary}");
            var boundary = '1';
            var lastIndexofOne = 0;
            for (int i = lastIndexofOne; i < binary.Length; i++)
            {
                if (binary[i] == boundary)
                {
                    //make this to be the start
                    var count = 0;
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '0')
                        {
                            count++;
                        }
                        else
                        {
                            //make this to be the end
                            lastIndexofOne = j;
                            if(count > maxlength)
                            {
                                maxlength = count;
                            }
                            break;
                        }
                    }
                }
            }
            return maxlength;
        }
    }
}
