using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lica_lib
{
    public class Palindromes
    {

        public static bool isPalindromeInAnagramOf(string inputString)
        {
            Func<int, bool> isCountEven = (count => count % 2 == 0);
            Func<int, bool> isCountOdd = (count => count % 2 == 1);

            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            
            foreach(char c in inputString)
            {
                if(charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts.Add(c, 1);
                }
            }
            
            var charOccurences = charCounts.Values;

            if (charOccurences.All(isCountEven))
            {
                return true;
            }

            if(charOccurences.Count(isCountOdd) == 1)
            {
                return true;
            }

            return false;
        }
    }
}
