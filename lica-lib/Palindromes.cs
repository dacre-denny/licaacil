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
        /// Determines if the input string is a palindrome, or if it is a anagram of a palindrome, returning true in either of these cases, and false otherwise.
        /// 
        /// The method achieves this by calculating the number of times characters occur in the input string, and uses this to determine the "symetery" of characters
        /// occurences in the input string, the key property of a palindrome. Because the method returns true for an anagram of a palindrome, there is no constraint 
        /// on the characters being ordered in any particular way.
        /// 
        /// </summary>
        /// <param name="inputStr">The string processed to determine if it is a palindrome or anagram of a palindrome.</param>
        /// <returns>Returns true if input string is a palindrome or anagram of a palindrome, otherwise returns.</returns>
        public static bool isPalindromeOrAnagramOfPalindrome(string inputStr)
        {
            Dictionary<char, int> charToCounts = new Dictionary<char, int>();

            //Build dictionary of count per character in inputStr. This dictionary is later used to detect the 
            //symmetry of input string (ie if it is a palindrome or anagram of a palindrome). 
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

            //Edge case - one character in the input string has occured an odd number of times. Symmetry of a
            //palindrome also exists in the string in this case. Applies to cases where input is a palindrome or anagram 
            //of a palindrome in a form such as "abb", "efgfe", "zzzez", etc
            if (charCounts.Count(isOdd) == 1)
            {
                return true;
            }

            //The symetry of a palindrome has not be found in the input string. Return false as per spec.
            return false;
        }
        
    }
}
