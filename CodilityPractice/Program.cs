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
            //var numberofZeroes = BinaryGap.Solution(2147483647);
            //Console.WriteLine($"The Max length for number of zeroes is : {numberofZeroes}");

            //OddOccurencesInArray implementation
            //var unpaired = OddOccurencesInArray.Solution(new int[] { 3, 4, 3, 4, 5, 3, 3, 5, 6, 7, 9, 9, 7, 14, 90, 32, 6, 14, 32, 90, 89 });
            //Console.WriteLine($"The value of unpaired element : {unpaired}");

            //CyclicRotation implementation
            //var arr = CyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("{0},", arr[i]);
            //}

            //FrogJmp Implementation
            //var noOfJumps = FrogJmp.Solution(40, 85, 30);
            //Console.WriteLine("The Number of Jumps is : {0}",noOfJumps);



            //var missElem = PermMissingElem.Solution(new int[] { 2, 1, 3, 5,6,4,7,8,10 });
            //Console.WriteLine("The missing Element is {0}",missElem);

            //var tpe = TapeEquilibrum.Solution(new int[] { 3, 1, 2, 4, 3 ,7,1,6,3,6,9,5});
            //Console.WriteLine("Minimum Value : {0}",tpe);


            //var X1 = 5;
            //int[] arr1 = { 1, 5, 1, 4, 2, 9, 3, 4 };
            //var X2 = 8;
            //int[] arr2 = { 3, 2, 6, 4, 8 };
            //var X3 = 5;
            //int[] arr3 = { 1, 2, 3, 4 };

            //Console.WriteLine(FrogRiverOne.Solution(X1, arr1));
            //Console.WriteLine(FrogRiverOne.Solution(X2, arr2));
            //Console.WriteLine(FrogRiverOne.Solution(X3, arr3));


            //MissingInteger implementation

            //var result = MissingInteger.Solution(new int[] { 1, 3, 6, 4, 1, 2 ,5});
            //var result = MissingInteger.Solution(new int[] { -1,-2 ,-3,1 });
            //var result = MissingInteger.Solution(new int[] { 1, 2, 3 });

            //Console.WriteLine("The Smallest Positive Integer : {0}",result);

            var pairedcars = PassingCars.Solution(new int[] { 0, 1, 0,1,1,0,1,1,0,1,0,1,0,1,1,1,1,0 });
            Console.WriteLine("The number of paired cars is : {0}", pairedcars);


            Console.ReadLine();
        }

    }
}