﻿using System.Text;

namespace SpongebobMockingText
{
    internal static class Program
    {
        public static void Main(String[] args)
        {
            //get input
            string input = getLowerCaseInput();
            Char[] even = new char[(input.Length/2) + 1];
            Char[] odd = new char[(input.Length/2) + 1];
            splitString(input, even, odd);
            toUpperCase(even);
            string result = Join(even, odd);
            Console.WriteLine(result);
        }

        internal static string getLowerCaseInput()
        {
            Console.WriteLine("please enter the text");
            return Console.ReadLine().ToLower();
        }

        //splits the string into two with alternting chars. E.g. s = 123456 -> s1 = 135 ; s2 = 246
        internal static void splitString(string input, char [] even, char[] odd){ 
            throw new NotImplementedException();
        }

        internal static void toUpperCase(char [] arr){
            for(int i = 0; i < arr.Length; i++){
                arr[i] = char.ToUpper(arr[i]);
            }
        }

        internal static String Join(char[] even, char[] odd)
        {
            StringBuilder returnString = new StringBuilder();
            // Calculate the maximum length to ensure both arrays are fully processed
            int maxLength = Math.Max(even.Length, odd.Length);
            for (int i = 0; i < maxLength; i++)
            {
                // Append from even array if within bounds
                if (i < even.Length)
                {
                    returnString.Append(even[i]);
                }
                // Append from odd array if within bounds
                if (i < odd.Length)
                {
                    returnString.Append(odd[i]);
                }
            }
            return returnString.ToString();
        }
    }
}