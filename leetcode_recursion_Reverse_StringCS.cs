
/*
 
https://leetcode.com/explore/learn/card/recursion-i/250/principle-of-recursion/1440/

 Write a function that reverses a string. The input string is given as an array of characters char[].

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

You may assume all the characters consist of printable ascii characters.

Example 1:

Input: ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
Example 2:

Input: ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_recursion_Reverse_StringCS
{
    class solution 
    {
        public static char[] swap_first_and_last_character(char[] s, int left, int right)
        {
            // it will swap the char at the char array at the left and the right position and will return

            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            return s;
        }

        public static  void reverse_the_string_using_recursion(char[] s, int left, int right)
        {
            if (left < right)   
            {
                // recurse the string if it contains atleast two charactrs in the string 
                // call the swap function to do the  actual swapping 
                swap_first_and_last_character(s, left, right);

                // recurse the same function with the smaller problem ( problem decreases by size : 2 
                reverse_the_string_using_recursion(s, left + 1, right - 1);
            }
        }

        public static void ReverseString(char[] s)
        {
            // it will recieve the string from driver function to reverse it 
            // left  = beginning of the string 
           //  right = last character of the string 
            int left  = s.GetLowerBound(0);  // 0
            int right = s.GetUpperBound(0);  // 4 

            // call the helper function reverse_the_string_using_recursion , which actually reverses the string 
            reverse_the_string_using_recursion(s, left, right);
        }

        static void Main(string[] args)
        {
            char[] buffer = new char[] { 'h', 'e', 'l', 'l', 'o' };
            // declare a character array , which contains the list of characters .

            // print the character items in the collection : 
            Console.Write("the elements in the collection are : ");
            foreach (char value in buffer )
            {
                Console.Write(value + " ");
               
            }
            Console.WriteLine();

            // call the reverse-string function  to reverse the string using recursion in-place without using the extra memory.  
            ReverseString(buffer);
            // print the character items in the collection : 
            Console.Write("reverse elements  in the collection after the reverse call are : ");
            foreach (char value in buffer)
            {
                Console.Write(value + " ");

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
