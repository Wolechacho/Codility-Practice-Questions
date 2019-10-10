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
            var numberofZeroes = BinaryGap.Solution(2147483647);
            Console.WriteLine($"The Max length for number of zeroes is : {numberofZeroes}");

            //OddOccurencesInArray implementation
            var unpaired = OddOccurencesInArray.Solution(new int[] { 3, 4, 3, 4, 5, 3, 3, 5, 6, 7, 9, 9, 7, 14, 90, 32, 6, 14, 32, 90, 89 });
            Console.WriteLine($"The value of unpaired element : {unpaired}");

            //CyclicRotation implementation
            var arr = CyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0},", arr[i]);
            }

            //FrogJmp Implementation
            var noOfJumps = FrogJmp.Solution(40, 85, 30);
            Console.WriteLine("The Number of Jumps is : {0}",noOfJumps);

            Console.ReadLine();
        }
    }
}