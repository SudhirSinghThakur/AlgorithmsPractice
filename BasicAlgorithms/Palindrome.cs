using System;

namespace BasicAlgorithms
{
    /// <summary>
    /// Program
    /// </summary>
    class Palindrome
    {
        /// <summary>
        /// Main method.
        /// Starting point of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter the input string : ");
            string input = Console.ReadLine();
            Console.WriteLine("IsPalindrome : {0}", IsPalindrome(input));
            Console.ReadKey();
        }

        /// <summary>
        /// Program to find the given string is palindrome or not.
        /// The bestcase runtime of this method will be logN.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string input)
        {
            for (int index = 0; index < input.Length / 2; index++)
            {
                if (input[index] != input[(input.Length - 1) - index])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
