using System;
using System.IO.Pipelines;

namespace CodePrac
{
    class Program
    {
        static void Main(string[] args)
        {

        //Write a function to reverse a string without using built-in reverse methods.

        System.Console.Write("Enter the string you want to reverse : ");
        
        string ?inputString = Console.ReadLine();
        int slen = inputString.Length;

        char[] Result = reverseString(inputString,slen);
        System.Console.WriteLine(Result);
       
            
        }
         // functions

    public static char[] reverseString( string input, int length)
        {
            char[] rString = new char[length];
            int j = length -1;

            foreach(var a in input)
            {
                rString[j] = a;
                j--;

            }




            return rString;

            

        }
    }
   
}