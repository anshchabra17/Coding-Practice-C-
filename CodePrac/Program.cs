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

            // int[] GivenArray = new int[] {1,2,3,4,7,8,3};
            // int target = 9;

            // int[] Result = FindIndexes(GivenArray,target);

            // foreach(var a in Result)
            // {
            //     System.Console.Write(a+ " ");
            // }

            //Implement a function to check if a given string is a palindrome. 
            // A palindrome reads the same backward as forward.

            // Example:
            // Input: "racecar"
            // Output: true

            // Input: "hello"
            // Output: false

            // Write the solution in C# using basic string operations and loops (without
            //  using built-in reverse functions).

            // System.Console.WriteLine("enter to check if palindrome : ");
            // string ?inpString = Console.ReadLine();

            // if (inpString == "")
            // {
            //     System.Console.WriteLine("empty string");
            // }
            // else
            // {
            //     bool res = checkPalindrome(inpString);
            //     System.Console.WriteLine(res);
            // }

            //Write a method to find the maximum and minimum values in an integer array.
            // Requirements:
            // The method should accept an integer array as input.
            // It should return both the maximum and minimum values found.
            // Do not use built-in sorting or max/min functions.
            // Example:
            // Input:​
            // Output: Max = 9, Min = 2
            // int[] SArr = new int[] {11,21,41,53,54,34,23,34,8};

            // FindMaxandMin(SArr);

            //Given two sorted integer arrays, write a function that merges them into one sorted array.
            // Requirements:
            // Input: two sorted arrays (e.g., and )
            // Output: one sorted array containing elements from both inputs (e.g., )
            // Do not use built-in sort methods; merge while maintaining order using loops and conditionals.
            // Try to implement this in C# using array manipulation.

           int[] Arr1 = new int[] {1,3,4,5,7,8,9};
           int[] Arr2 = new int[] {2,4,6,8,9,10};

           int[] resArr = MergeTwoSortedArray(Arr1,Arr2);

           foreach(var x in resArr)
            {
                System.Console.Write(x +" ");
            }
        }
        // functions

        public static int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
        {
            int[] resarr = new int[arr1.Length + arr2.Length ];
            int i=0,j=0,k=0;
            
            while(i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    resarr[k]=arr1[i];
                    k++;
                    i++;
                }
                else
                {
                    resarr[k]=arr2[j];
                    j++;
                    k++;
                }
                
            }
           while (i < arr1.Length)
                {
                    resarr[k]=arr1[i];
                    i++;
                    k++;
                }
                 while (j < arr2.Length)
                {
                    resarr[k]=arr2[j];
                    j++;
                    k++;
                }
            return resarr;
        }

        
        public static void FindMaxandMin(int[] SArr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < SArr.Length; i++)
            {
                if (SArr[i] < min)
                {
                    min = SArr[i];
                }
                if (SArr[i] > max)
                {
                    max = SArr[i];
                }
            }
            System.Console.WriteLine($"Max : {max} Min : {min}");
        }

        public static bool checkPalindrome(string inpString)
        {
            bool res;
            string str1 = inpString.ToLower();
            string str2 = ReverseString(str1);

            if (str1 == str2)
            {
                res = true;
            }
            else
            {
                res = false;
            }


            return res;


        }
        public static int[] FindIndexes(int[] Garray, int target)
        {
            int[] result = new int[2];

            int arraylen = Garray.Length;

            for (int i = 0; i < arraylen; i++)
            {
                for (int j = 0; j < arraylen; j++)
                {
                    if (Garray[i] + Garray[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }


            return result;
        }

        public static string ReverseString(string input)
        {
            int length = input.Length;
            char[] rString = new char[length];
            int j = length - 1;

            foreach (var a in input)
            {
                rString[j] = a;
                j--;

            }




            return new string(rString);



        }
    }

}