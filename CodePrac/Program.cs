using System;
using System.IO.Pipelines;

namespace CodePrac
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a function to reverse a string without using built-in reverse methods.

            // System.Console.Write("Enter the string you want to reverse : ");

            // string ?inputString = Console.ReadLine();
            // int slen = inputString.Length;

            // char[] Result = reverseString(inputString,slen);
            // System.Console.WriteLine(Result);

            //Given an array of integers and a target number, write a function
            //  to find the indices of two numbers in the array that add up to
            //  the target. Return the indices as an array. If no such numbers exist,
            //  return an empty array.

            // Example:
            // Input: nums =, target = 9​
            // Output: (because nums + nums = 2 + 7 = 9)​

            // Write the solution in C# with appropriate input reading if you want, or use hardcoded data to test.

            int[] GivenArray = new int[] {1,2,3,4,7,8,3};
            int target = 9;

            int[] Result = FindIndexes(GivenArray,target);

            foreach(var a in Result)
            {
                System.Console.Write(a+ " ");
            }



        }
        // functions

        public static int[] FindIndexes(int[] Garray, int target)
        {
            int[] result = new int[2];
              
            int arraylen = Garray.Length;

            for(int i = 0; i < arraylen; i++)
            {
                for(int j = 0; j < arraylen; j++)
                {
                    if(Garray[i]+Garray[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }  
            
            
            return result;
        }

















        public static char[] reverseString(string input, int length)
        {
            char[] rString = new char[length];
            int j = length - 1;

            foreach (var a in input)
            {
                rString[j] = a;
                j--;

            }




            return rString;



        }
    }

}