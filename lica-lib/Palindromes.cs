using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lica_lib
{
    /// <summary>
    /// Utility class for functions relating to palindrome classification 
    /// </summary>
    public class Palindromes
    {
        /// <summary>
        /// Determines if the characters in the input string can be reorganised into a palindrome.
        /// 
        /// The order of characters in the input string does not is not important. We need to look at the number of times character(s)
        /// occur in the input string, to determine if the string can be reorganised into a palindrome (ie an anagram of a palindrome).
        /// With the number of occurances per character, we then detect the possibility of a palindrome in the string by "symetery" of a palindrome in
        /// 
        /// </summary>
        /// <param name="inputStr">The string that is processed to determine if it can be reorganised into a palindrome.</param>
        /// <returns>Returns true is characters of input string can be reorganised into a palindrome. Returns false otherwise.</returns>
        public static bool isPalindromeInAnagramOf(string inputStr)
        {
            Dictionary<char, int> charToCounts = new Dictionary<char, int>();

            //Build dictionary of count per character in inputStr. This dictionary is later used to detect the 
            //symmetry of a palindrome or anagram of a palindrome in the string. 
            foreach (char c in inputStr)
            {
                if(charToCounts.ContainsKey(c))
                {
                    charToCounts[c] ++;
                }
                else
                {
                    charToCounts[c] = 1;
                }
            }

            //Declare predecate functions for improved readability in subsequent code
            Func<int, bool> isEven = (count => count % 2 == 0);
            Func<int, bool> isOdd = (count => count % 2 == 1);

            Dictionary<char, int>.ValueCollection charCounts = charToCounts.Values;

            //If all unique characters in input string have occurred an even number of times, then the symmetry of
            //a palindrome exists in the string. Early exit with return true.
            if (charCounts.All(isEven))
            {
                return true;
            }

            //If one character in the input string has occured an odd number of times, then the symmetry of a
            //palindrome exists in the string. This edge case indicates the input string is a palindrome or anagram 
            //of a palindrome, in a form such as "abb", "efgfe", "zzzez", etc
            if (charCounts.Count(isOdd) == 1)
            {
                return true;
            }

            //The symetry of a palindrome has not be found in the input string. Return false as per spec.
            return false;
        }
    }
}
