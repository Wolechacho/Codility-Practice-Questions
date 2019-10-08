using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryGap implementation
           var numberofZeroes =  BinaryGap.Solution(2147483647);
            Console.WriteLine($"The Max length for number of zeroes is : {numberofZeroes}");
            Console.ReadLine();
        }
    }
}
