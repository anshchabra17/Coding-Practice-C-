using System;
using System.Globalization;
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

            //    int[] Arr1 = new int[] {1,3,4,5,7,8,9};
            //    int[] Arr2 = new int[] {2,4,6,8,9,10};

            //    int[] resArr = MergeTwoSortedArray(Arr1,Arr2);

            //    foreach(var x in resArr)
            //     {
            //         System.Console.Write(x +" ");
            //     }














            // Write a function to remove duplicate integers from an unsorted array.
            // Requirements:
            // Input: an unsorted integer array
            // Output: a new array containing only unique elements (no duplicates)
            // No built-in functions for distinct or sets allowed
            // Use loops and conditionals to implement



            // int[] Uarr = new int[] { 23,54,1,23,45,23,12,54,32,23,12,98};

            // List<int> resArr = RemoveDuplicates(Uarr);
            // foreach (var a in resArr)
            // {
            //     System.Console.Write(a+ " ");
            // }




            //Find the first non-repeating character in a string.
            // Requirements:
            // Given a string, return the index of the first character that appears only once.
            // If no such character exists, return -1.
            // Use only basic loops and arrays (no built-in dictionaries or hashsets if possible).
            // Example:
            // Input: "leetcode"
            // Output: 0 (because 'l' is the first non-repeating character)
            // Input: "loveleetcode"
            // Output: 2 (because 'v' is the first non-repeating character)
            // Input: "aabb"
            // Output: -1 (no non-repeating characters)

            //     System.Console.WriteLine("enter a string : ");
            //     string? Istring = Console.ReadLine();

            //     if (string.IsNullOrEmpty(Istring))
            //     {
            //         System.Console.WriteLine("Invalid Input");
            //     }
            //     else
            //     {
            //         int result = FindNonReapting(Istring);
            //         System.Console.WriteLine(result);
            //     }



            // }
            // // functions

            // public static int FindNonReapting(string str)
            // {
            //     int result = -1;

            //     for(int i = 0; i < str.Length; i++)
            //     {
            //         bool copyfound = false;
            //         for(int j = i+1; j < str.Length; j++)
            //         {
            //             if (str[i] == str[j])
            //             {
            //                 copyfound = true;
            //                 break;
            //             }

            //         }
            //         if(copyfound == false)
            //         {
            //             result = i;
            //             break;
            //         }
            //     }


            //     return result;







            //         Question 8: Check if one string is a rotation of another.
            // Requirements:
            // Given two strings s1 and s2, check if s2 is a rotation of s1.
            // Example: s1 = "abcd", s2 = "cdab" → true, because s2 is s1 rotated by 2 positions.
            // Example: s1 = "abcd", s2 = "acbd" → false.
            // Hint:
            // A classic approach is to check if s2 is a substring of s1 concatenated with itself (s1 + s1).

            //    string str1 = "abcd";
            //    string str2="bcda";

            //    bool res = checkrotation(str1,str2);

            //    System.Console.WriteLine(res);

            //Reverse words in a sentence while maintaining word order.
            // Requirements:
            // Given a sentence, reverse each word individually but keep the original word order.
            // Do not use built-in reverse functions for individual words.
            // Use loops and string manipulation.
            // Example:
            // Input: "Hello World Java"
            // Output: "olleH dlroW avaJ"
            // Example:
            // Input: "I love coding"
            // Output: "I evol gnidoc"

            //    System.Console.WriteLine("enter a string : ");
            //    string? Istring = Console.ReadLine();






            //Question 1: Missing Number
            // Problem: Array contains numbers 1 to n (one missing). Find the missing number.
            // Input: Array of integers + size n
            // Test Cases:

            // text
            // Test 1: n=6, array=[1,2,4,5,6] → Output: 3
            // Test 2: n=4, array=[1,3,4,2] → Output: 0  
            // Test 3: n=3, array=[2,1,3] → Output: 0

        
        //     System.Console.WriteLine("enter the value of n ");
        //     int n = Convert.ToInt32(Console.ReadLine());
        //     int ArraySize = n-1;
        //     System.Console.WriteLine("enter array items : ");

        //     int[] arr = new int[ArraySize];
        //     for(int i = 0; i < ArraySize; i++)
        //     {
        //         arr[i] = Convert.ToInt32(Console.ReadLine());
        //     }

            
 
        //     int result = FindMissingNumber(arr,n);
        //     System.Console.WriteLine(result);
            
        // }
        //    public static int FindMissingNumber(int[] arr, int n)
        // {
        //     int result;
            
        //     int sumofarr =0;

        //     foreach(var x in arr)
        //     {
        //         sumofarr = sumofarr +x;
        //     }
        //     int sumtilln = (n*(n+1))/2;
        //     result = sumtilln - sumofarr;
              
            
              
            


        //     return result;
        
        }
 


        public static bool checkrotation(string str1, string str2)
        {
            bool res;

            string concatedstrings = str1 + str2;

            if (concatedstrings.Contains(str1))
            {
                res = true;
            }
            else res = false;



            return res;
        }







        public static List<int> RemoveDuplicates(int[] uarr)
        {
            List<int> resarr = new List<int> { };
            int len = uarr.Length;

            for (int i = 0; i < len; i++)
            {
                bool foundmatch = false;
                for (int j = 0; j < resarr.Count; j++)
                {
                    if (uarr[i] == resarr[j])
                    {
                        foundmatch = true;
                        break;
                    }
                }

                if (foundmatch == false)
                {
                    resarr.Add(uarr[i]);
                }

            }





            return resarr;
        }
        public static int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
        {
            int[] resarr = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    resarr[k] = arr1[i];
                    k++;
                    i++;
                }
                else
                {
                    resarr[k] = arr2[j];
                    j++;
                    k++;
                }

            }
            while (i < arr1.Length)
            {
                resarr[k] = arr1[i];
                i++;
                k++;
            }
            while (j < arr2.Length)
            {
                resarr[k] = arr2[j];
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